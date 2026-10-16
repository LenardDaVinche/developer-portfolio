
/**
 * Write a description of class Hat here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Hat
{
    private String hat;

    /**
     * Constructor for objects of class Hat
     */
    public Hat(String h)
    {
        hat = h;
    }

    /**
     * return the hat value
     *
     * @return  the value of hat variable.
     */
    public String getHat()
    {
        return hat;
    }
    
    /**
     * Mutate the hat variable 
     *
     * @param  new hatType string 
     * Set "hatType" to change the new String value of hat 
     */
    public void setHat(String hatType)
    {
        hat = hatType;
    }
}
