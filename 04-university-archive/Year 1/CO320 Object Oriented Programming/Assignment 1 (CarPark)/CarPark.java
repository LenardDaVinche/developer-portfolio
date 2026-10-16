/**
 * This CarPark class is used to showcase the location, capacity, current occupation and the availalbe spaces left on the carpark.
 * Cars will be able to park and leave the car park, but only if there is sufficent capacity.
 * The capacity of the carpark can be both increased or decreased, but only if the capacity isnt below 0 or the current occupancy.
 * Any errors with the management, such as lack of available spaces or capacity will be warned to the user.
 * The information about available spaces can be printed out to the user at any time.
 * 
 * @@author (Leandro Baroca)
 * @version (19/10/2018)
 */

public class CarPark
{
    // String field for location.
    // (used for the location in the car park).
    private String location;   
    // instance field for capacity. 
    // (used for the available spaces of the car park).
    private int capacity;
    // Instance field for occupancy.
    // (used for the filled spaces of the car park).
    private int occupancy;

    /**
     * @String parameter to store different instances to location String.
     * @Integer parameter to store different instances of capacity integer.
     * Create a car park which gives the location.
     * Create an integer to store the capacity of the car park.
     * Occupancy is always set to zero uppon creating an instance.
     */
    public CarPark(String parkLocation, int parkCapacity)
    {         
        location = parkLocation;
        capacity = parkCapacity;
        occupancy = 0;
    }

    /**
     * @Return the location of the car park.
     */
    public String getLocation()
    {
        return location;
    }

    /**
     * @Return the capacity of the car park.
     */
    public int getCapacity()
    {
        return capacity;
    }

    /**
     * @Return the occupancy of the car park.
     */
    public int getOccupancy()
    {
        return occupancy;
    }

    /**
     * If the capacity is the same or more than the occupation, give error message that car park is full.
     * Else the capacity is greater than the occupancy, add 1(a new car enters the car park to occupy a space).
     */
    public void park()
    {
        if (occupancy >= capacity){
            System.out.println("###############");            
            System.out.println("Capacity Error: The car park is full.");
            System.out.println("###############");
            System.out.println();
        }
        else {
            occupancy = occupancy + 1; 
        }
    }

    /**
     * If a user leaves the car park, reduce occupancy variable by 1 if it is above 0. Decreasing the occupation, therefore increasing capacity.
     * Else print an error message when the car park is empty (there is no occupation), saying that the occupancy cannot be reduced.
     */
    public void leave()
    {
        if (occupancy > 0) {
            occupancy = occupancy - 1; 
        }
        else {
            System.out.println("###############");
            System.out.println("Capacity Error: The car park is empty.");
            System.out.println("###############");
            System.out.println();
        }
    }

    /**
     * Create new capacity variable which contains the added variable (newCapacity) with the original capacity.
     * This allows user to change the capacity of the car park, by adding current value with new value (from parameter).
     * If occupancy is above 0 and the capacity is lower than the occupancy, remove added value from "newCapacity" variable from "capacity" variable.
     * Print out error message indicating that capacity cannot be lower than occupancy and that the original number is restored.
     * If the capacity is below zero, set capacity to 0. So there isn't negative capacity.
     * Print out error message indicating user that the car park is closed.
     */
    public void changeCapacity(int newCapacity)
    {
        capacity = newCapacity + capacity;
        if(occupancy > 0 && capacity < occupancy){
            capacity = capacity - newCapacity;
            System.out.println("###############");  
            System.out.println("Capacity Error: Cannot make capacity lower than current occupancy.");
            System.out.println("The capacity value will be reset to the original value.");
            System.out.println("###############");              
            System.out.println();
        }
        if(capacity < 0){
            capacity = 0;      
            System.out.println("###############");
            System.out.println("Attention! The carpark is now closed!");
            System.out.println("###############");            
            System.out.println();
        }
    }

    /**
     * Create new capacity variable to store the available spaces left on the car park.
     * Current capacity (capacity variable) minus the spaces occupied (occupancy variable).
     * If the capacity is equal to 1, print out "(location) car park has (capacity = 1) space".
     * Else print out "(location) car park has (capacity greater than 1, or 0) spaces".
     */
    public void printDetails()
    {
        capacity = capacity - occupancy;
        System.out.println("###############");
        if(capacity == 1){
            System.out.println(location + " car park has " + capacity 
                + " space.");
        }
        else{
            System.out.println(location + " car park has " + capacity 
                + " spaces.");    
        }
        System.out.println("###############");
        System.out.println();
    }
}
