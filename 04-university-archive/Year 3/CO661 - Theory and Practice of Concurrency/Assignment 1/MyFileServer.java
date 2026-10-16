// CO661 - Theory and Practice of Concurrency
// School of Computing, University of Kent
// Leandro J. Gomes Baroca (lb676)

// Description: The approach to this concurrent process is by having two semaphores and two locks. 
// The first semaphore will have 1 permit, as it is a read/write access permit. 
// So no locks are requried as a race condition couldn't happen.
// I have a second semaphore with an integer max value, and with this many permits the 
// threads can start accessing the same permit (which is a race condition).

// To avoid race conditions, I have implemented a lock called "readlock" 
// to prevent multiple threads from accessing the semaphore of integer MAX,
// this is so one thread is entering a readable file seperate from another thread. 
// Which also promotes mutual exclusion.
// This same logic applies with closing the file, which is why I have a second lock
// called "closelock".

// To promote fairness, I have assigned both semaphore's fairness boolean as true.
// This is so the thread that has been waiting for the permit the longest,
// gets priority to this permit over the other threads that have been in a shorter time span.

import java.util.HashMap;
import java.util.Optional;
import java.util.Set;
import java.util.concurrent.Semaphore;
import java.util.concurrent.locks.ReentrantLock;

class FileData extends FileFrame {
    private Semaphore writeable = new Semaphore(1, true);
    private Semaphore readable = new Semaphore(Integer.MAX_VALUE, true);
    private ReentrantLock readlock = new ReentrantLock();
    private ReentrantLock closelock = new ReentrantLock();

    FileData(String content, Mode mode) {
        super(content, mode);
    }

    // Add to queue of readers (MAX_VALUE)
    // Sets the mode of the file to "READABLE"
    // Creates new file with it's name, content for reading and the mode its
    // currently in
    // Returns the readable file
    public File getFileForReading(String filename) {
        try {
            readlock.lock();
            System.out.println("READ: locked");

            if (mode != Mode.READABLE) {
                System.out.println(Thread.currentThread().getName() + " is acquiring the readwrite semaphore for reading");
                System.out.println("There are " + readable.getQueueLength() + " threads waiting to read/write");
                System.out.println("Readlock available permits: " + (readable.availablePermits()));

                writeable.acquire();

                System.out.println("readwrite aquired");
            }

            System.out.println(Thread.currentThread().getName() + " is acquiring the read semaphore for reading");
            readable.acquire();

            this.mode = Mode.READABLE;

            readlock.unlock();
            System.out.println("READ: unlocked");

            File file = new File(filename, this.content, this.mode);
            System.out.println("returning read file");

            return file;

        } catch (InterruptedException e) {
            // if the thread is interrupted while waiting, reinterrupt it
            Thread.currentThread().interrupt();
            System.out.println("READ: interrupt");
            return null;
        }

    }

    // Add to queue of writers (1 maximum integer value)
    // Sets the mode of the file to "READWRITABLE"
    // Creates new file with it's name, content for writing and the mode its
    // currently in
    // Returns the writable file
    public File getFileForWriting(String filename) {
        try {
            System.out.println(Thread.currentThread().getName() + " is acquiring the readwrite lock for writing");
            System.out.println("There are " + writeable.getQueueLength() + " threads waiting to read/write");
            System.out.println("Writelock available permits: " + (writeable.availablePermits()));

            writeable.acquire();

            System.out.println("readwrite aquired");

            this.mode = Mode.READWRITEABLE;

            File file = new File(filename, this.content, this.mode);

            System.out.println("returning readwrite file");
            return file;

        } catch (InterruptedException e) {
            // if the thread is interrupted while waiting, reinterrupt it
            Thread.currentThread().interrupt();
            System.out.println("READWRITE: interrupt");

            return null;
        }
    }

    // If the mode is set to readable, release the read permits
    // If the readers are the maximum amount (everyone is a reader), release write
    // permit
    // Else, release a writer permit
    public void close() {
        System.out.println("There are " + readable.getQueueLength() + " threads waiting to close");

        if (this.mode == Mode.READABLE) {
            closelock.lock();
            System.out.println("CLOSE: locked");

            readable.release();
            System.out.println("CLOSE: READ released");

            if (readable.availablePermits() == Integer.MAX_VALUE) {
                writeable.release();
                System.out.println("CLOSE: READWRITE released");

                this.mode = Mode.CLOSED;
                System.out.println("Mode.CLOSED");
            }

            closelock.unlock();
            System.out.println("CLOSE: unlocked");

        } else if (this.mode == Mode.READWRITEABLE) {
            writeable.release();
            System.out.println("CLOSE: READWRITE released");

            this.mode = Mode.CLOSED;
            System.out.println("Mode.CLOSED");
        }
    }
}

public class MyFileServer implements FileServer {
    private HashMap<String, FileData> map = new HashMap<String, FileData>();

    // Create a new file on the server
    public void create(String filename, String content) {
        System.out.println("Creating File");
        map.put(filename, new FileData(content, Mode.CLOSED));
        System.out.println("File Created");
    }

    // Attempt to open a file -- may block if the file is not available at that mode
    // Returns an Optional.empty() if no such file exists
    public Optional<File> open(String filename, Mode mode) {
        if (map.containsKey(filename)) {
            FileData frame = map.get(filename);

            if (mode == Mode.READABLE) {
                return Optional.of(frame.getFileForReading(filename));
            } else if (mode == Mode.READWRITEABLE) {
                return Optional.of(frame.getFileForWriting(filename));
            } else {
                return Optional.empty();
            }
        } else {
            return Optional.empty();
        }
    }

    // Close a file
    public void close(File file) {
        System.out.println("Closing File: " + file.filename());
        FileData data = map.get(file.filename());

        if (data == null) {
            System.out.println("close: file not found");
        } else {
            if (data.mode != file.mode()) {
                System.out.println("Invalid close mode");
            } else {
                data.content = file.read();
                data.close();
                System.out.println("close: file closed");
            }
        }
    }

    // Check on the status of a file (the mode it is currently in)
    public Mode fileStatus(String filename) {
        FileData frame = map.get(filename);
        if (frame == null) {
            return Mode.UNKNOWN;
        } else {
            return frame.mode;
        }
    }

    // What files are available on the server?
    public Set<String> availableFiles() {
        return map.keySet();
    }
}