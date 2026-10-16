
/**
 * Write a description of class BubbleSort here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class BubbleSort
{
    private int [] array = {78, 25, 90, 1, 34, 2, 56, 6};
    private int y = 0;
    public void sort()
    {
        for(int lst=array.length-1; lst>0; lst--){
            for(int i=0; i<lst; i++){
                if(array[i]>array[i+1]){
                    y=array[i];
                    array[i]=array[i+1];
                    array[i+1]=y;
                }
            }
        }
    }
}
