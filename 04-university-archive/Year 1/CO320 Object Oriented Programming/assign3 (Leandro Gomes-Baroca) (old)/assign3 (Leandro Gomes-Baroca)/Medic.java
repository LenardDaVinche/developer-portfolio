
/**
 * A class storing details of a medic. 
 * (Superclass of Nurse and Doctor; Subclass of Person)
 * 
 * @author Leandro J Gomes Baroca
 * @version 2019.01.13
 */
public class Medic extends Person
{
    /**
     * Constructor for objects of class Medic
     * @param name The medic's name.
     * @param The title of the medic.
     */
    public Medic(String nameInput, String titleInput)
    {
        super(nameInput, titleInput);
    }
    
    /**
     * Return a string in the form "Title Name (ID)"
     * if a title is present, or "Name (ID)" if there is no title.
     * @return A string containing the medic's title (optional) and name.
     */
    public String toString()
    {
        String output = getTitle() + " " + getName();
        return output.trim();
    }
}