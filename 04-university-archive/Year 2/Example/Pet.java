
/**
 * Write a description of class Pet here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Pet
{
    private String name;

    /**
     * Constructor for objects of class Pet
     */
    public Pet(String nm)
    {
        name = nm;
    }

    /**
     * Returns the "name" variable once declared
     *
     * @return  The "name" String field
     */
    public String getName()
    {
        return name;
    }

    /**
     * Mutate the name of Pet
     *
     * @param   Create new parameter String called "nme"
     * @return  Set "nme" string to return the value "name" field
     */
    public void setName(String nme)
    {
        name = nme;
    }
}
