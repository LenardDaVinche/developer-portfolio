/**
 * A class storing details of a nurse.
 * (Subclass of Medic)
 * 
 * @author Leandro J. Gomes Baroca
 * @version 2019.01.13
 */
public class Nurse extends Medic
{
    /**
     * Set the nurse's name and title.
     * @param name The nurse's name.
     * @param The title of the nurse.
     */
    public Nurse(String name, String title)
    {
        super(name,"Nurse");
    }
}

