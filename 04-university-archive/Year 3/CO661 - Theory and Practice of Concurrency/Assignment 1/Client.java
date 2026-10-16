// CO661 - Theory and Practice of Concurrency
// School of Computing, University of Kent
// Leandro J. Gomes Baroca (lb676)

import java.util.ArrayList;
import java.util.List;
import java.util.Set;
import java.util.concurrent.ThreadLocalRandom;

public class Client implements Runnable {
  private FileServer fs;
  private File file;

  public static void main(String[] args) {
    FileServer fs = new MyFileServer();

    fs.create("file 1", "content");
    fs.create("file 2", "content");
    fs.create("file 3", "content");
    fs.create("file 4", "content");

    // Create new Clients(fs)
    // Start them using Thread(client);
    // Call the threads using thread.start();
    Client client1 = new Client(fs);
    Client client2 = new Client(fs);
    Client client3 = new Client(fs);

    Thread thread1 = new Thread(client1);
    Thread thread2 = new Thread(client2);
    Thread thread3 = new Thread(client3);

    thread1.start();
    thread2.start();
    thread3.start();
  }

  Client(FileServer fileServer) {
    this.fs = fileServer;
  }

  @Override
  public void run() {
    try {
      while (true) {

        Thread.sleep(1000 * ThreadLocalRandom.current().nextInt(1, 3));

        // Pick a file using availableFiles()
        Set<String> availableFiles = fs.availableFiles();
        int random = ThreadLocalRandom.current().nextInt(0, availableFiles.size() - 1);
        List<String> list = new ArrayList<String>(availableFiles);
        String filename = list.get(random);

        // Read or write to it using a random bool
        if (ThreadLocalRandom.current().nextBoolean()) {
          // write to file
          file = fs.open(filename, Mode.READWRITEABLE).get();

          file.write(file.read() + " test");
          System.out.println("wrote: " + file.read());

        } else {
          // read from file
          // check if file is not null
          file = fs.open(filename, Mode.READABLE).get();
          System.out.println("read: " + file.read());

        }

        Thread.sleep(1000 * ThreadLocalRandom.current().nextInt(1, 3));
        // close
        // check if file is not null
        if (file != null) {
          fs.close(file);
        }
      }

    } catch (InterruptedException e) {
      Thread.currentThread().interrupt();
    }
  }
}