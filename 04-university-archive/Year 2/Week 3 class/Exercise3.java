import java.util.Scanner;
public class Exercise3
{
    public int array[];
    public int size;
    private Scanner sc;
    public Exercise3()
    {
        sc = new Scanner(System.in);
    }

    public void createArray()
    {
        System.out.print("Enter the size of the array: ");
        int size = sc.nextInt();
        array = new int[2*size];

        System.out.print("Enter the elements into the array: ");
        for(int j=0; j<size; j++){
            array[j]=sc.nextInt();
        } 
    
        System.out.print("Your array is: ");
        for(int i=0; i<size*2; i++){
            System.out.print("|" + array[i]);
        }
        System.out.print("|");
        System.out.println();
    }
}
