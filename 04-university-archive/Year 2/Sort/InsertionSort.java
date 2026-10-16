
public class InsertionSort
{
    private int [] array = {78, 25, 90, 1, 34, 2, 56, 6};
    private int check, value;
    public void sort()
    {
        for(int i=1; i < array.length; i++){
            value=array[i];
            check = i;
            while(check > 0 && (array[check-1] > value)){
                array[check]=array[check-1];
                check--;
            }
            array[check]=value;
        }
        for(int x=0; x < array.length-1; x++){
            System.out.println(array[x]);
        }
    }
}