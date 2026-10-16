
/**
 * Write a description of class SelectionSort here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class SelectionSort
{
    private int [] array = {78, 25, 90, 1, 34, 2, 56, 6};
    private int min, value;
    public void sort()
    {
        for(int i=0; i < array.length-1; i++){
            min = i;
            for(int j = i + 1; j < array.length; j++){
                if(array[j] < array[min]){
                    min = j;
                }
                if(array[min] !=i){
                    value = array[min];
                    array[min] = array[i];
                    array[i] = value;
                }
            }
            for(int x=0; x < array.length; x++){
                System.out.println(array[x]);
            }
        }
    }
}
