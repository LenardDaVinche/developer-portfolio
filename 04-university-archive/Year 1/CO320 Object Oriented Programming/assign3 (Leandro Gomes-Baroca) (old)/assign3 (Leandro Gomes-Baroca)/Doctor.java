/**
 * A class storing details of a doctor.
 * (Subclass of Medic)
 * 
 * @author Leandro J Gomes Baroca
 * @version 2019.01.13
 */
public class Doctor extends Medic
{
    /**
     * Set the doctor's name and title.
     * @param name The doctor's name.
     * @param The title of the doctor.
     */
    public Doctor(String name, String title)
    {
        super(name,"Dr.");
    }
}
