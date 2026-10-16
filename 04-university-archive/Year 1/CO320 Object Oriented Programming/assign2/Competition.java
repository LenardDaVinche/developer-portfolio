import java.util.ArrayList;
import java.util.Iterator;
import java.util.Comparator;
/**
 * This Competition class is used to store, arrange and showcase data from the Personality class for a competition of votes.
 * The list can contain as many people as possible, but only if there aren't any duplicated names stored.
 * The amount of votes per person can be increased, but not decreased.
 * Shorter lists can be created, such as putting a minimum amount of votes needed to be in said list 
 * or the objects with the most votes (Amount determined by user).
 * The information about the list can be printed out to the user at any time.
 * Error messages will appear when inavlid inputs are created by the user.
 * 
 * @author (Leandro J. Gomes Baroca) 
 * @version (21/11/2018)
 */
public class Competition
{
    //Assign name for ArrayList.
    //(used to create a list containing personalities.)
    private ArrayList<Personality> personList;

    /**
     * Create a "personList" ArrayList to list the objects from the Personality class.
     */
    public Competition()
    {
        personList = new ArrayList<>();
    }

    /**
     * @param "person" variable to Personality class to store the objects found within the Personality class.
     * Give "personList" ArrayList the ability to add objects from Personality class, via parameter variable.
     */
    public void addPersonality(Personality person)
    {
        personList.add(person);
    }

    /**
     * @return Returns the size of the ArrayList containing the objects of the Personality class.
     */
    public int getSize()
    {
        return personList.size(); 
    }

    /**
     * Create a for loop with "Perosnality" class assigned "print" temporary variable, which incrimets objects from the "personList".
     * Print a line containing the contents of the "personList" ArrayList via ".getDetails()".
     */
    public void list()
    {
        for(Personality print : personList) {
            System.out.println();
            System.out.println(print.getDetails());
        }
    }

    /**
     * @param "name" String to store the name user inputs through the method.
     * New Iterator list from the "Personality" class named "voteList", which contains the "personList" (ArrayList) with the original objects.
     * While loop where the it returns true if the method returns a boolean data type (true), serving as a flag if there are objects to iterate over.
     * Assign the Personality class as "votes", which is then assigned to the "voteList".
     * If the name of voteList equals the name of the Personality class objects, increase the votes on Personality class objects by 1.
     * @return Return true to cancel out the "voteFor" method.
     * When the method doesn't return true on the while loop, an error message will be printed out.
     */
    public void voteFor(String name)
    {
        Iterator<Personality> voteList = personList.iterator();
        while(voteList.hasNext()){
            Personality votes = voteList.next();
            if(name.equals(votes.getName())){
                votes.increaseVotes(1);
                return;
            }
        }
        System.out.println();
        System.out.println("Error: Name not found");
    }

    /**
     * @param "minimumVotes" integer to store a numerical (user input) value to carry out the rest of the method.
     * New Iterator list from the "Personality" class named "list", which contains the "personList" (ArrayList) with the original objects.
     * While loop where the it uses a ".hadNext" serving as a flag if there are objects to iterate over on the "list" Iterator.
     * If the next vote (from "getVotes()") within the Personality list is below the minimumVotes, remove the list. 
     */
    public void shortlist(int minimumVotes)
    {
        Iterator<Personality> list = personList.iterator();
        while (list.hasNext()) {
            if (((Personality)list.next()).getVotes() < minimumVotes){
                list.remove();
            }
        }
    }

    /**
     * @param "index" integer variable to store (user input) value that will be used to choose the top select few of the Personality object list.
     * Create new clone list of the "personList" ArrayList under the name of "newList".
     * Sort the new list with a comparitor by the amount of votes (getVotes()) in reverse order.
     * If index is equal to zero, clear the list.
     * return Returns The empty list.
     * Else if the index is greater than or equal to the number of personalities, all personalities in the list are returned.
     * return Returns the full list.
     * While loop created when index is smaller than the size of the new list (newList) and index is not 0.
     * If the newlist index and amount of votes is not equal to one vote below index, remove index.
     * Else add index by 1.
     * @return The newly created list containing the top selected objects depending on the index.
     */
    public ArrayList<Personality> getMost(int index)
    {
        ArrayList<Personality> newList = (ArrayList<Personality>)personList.clone();
        newList.sort(Comparator.comparingLong(Personality::getVotes).reversed());
        if(index == 0){
            newList.clear();
            return newList;
        }else if(index >= newList.size()){
            return newList;
        }
        while(index < newList.size() && index !=0){
            if(newList.get(index).getVotes() != newList.get(index-1).getVotes()){
                newList.remove(index);
            }else{
                index++;
            }
        }
        return newList;
    }
}
