
/**
 * A superclass storing details of a person.
 * (Superclass of Medic and Patient)
 * 
 * @author Leandro J Gomes Baroca
 * @version 2019.01.13
 */
public class Person
{
    // The person's full name
    private String name;
    // The person's title
    private String title;

    /**
     * Return the person's name.
     * @param The name of this person.
     * @param The title of this person.
     */
    public Person(String perName, String perTitle)
    {
        perName = name;
        perTitle = title;
    }

    /**
     * Return the full name of this person.
     * @return The full name of this person.
     */
    public String getName()
    {
        return name;
    }

    /**
     * Return the person's title.
     * @return The title of this person.
     */
    public String getTitle()
    {
        return title;
    }

    /**
     * Return the person's new title.
     * @param newTitle The new title of this person.
     */
    public void changeTitle(String newTitle)
    {
        title = newTitle;
    }
}
