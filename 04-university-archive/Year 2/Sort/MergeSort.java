
public class MergeSort
{

    public void printArray(int [] array)
    {
        for(int i=0; i < array.length; i++){
            System.out.print(array[i] + " ");
        }
        System.out.println();

        array = mergeSort(array);
        for(int i=0; i < array.length; i++){
            System.out.println(array[i]);
        }
    }

    public int [] mergeSort(int [] array)
    {
        if (array.length <=1){
            return (array);
        }

        int mid = array.length / 2; //find the middle of the array
        int [] left = new int [mid]; //define the left side of the array
        int [] right; //define right side of the array
        
        if(array.length % 2 ==0)
        {
            right = new int [mid]; 
        }else{
            right = new int[mid + 1];
        }
        
        for(int i=0; i < mid; i++){
            left[i] = array[i];
        }
        
        for(int j=0; j < mid; j++){
            right[j] = array[j];
        }
        
        int [] resultsMS = new int[array.length];
        
        left = mergeSort(left); //recursion
        right = margeSort(right); //recursion
        
        resultMS = merge(left, right);
        return resultMS;
    }
    
    public int [] merge(int [] left, int [] right)
    {
        int [] result = new int [left.length + right.length];
        
        int leftP = 0;
        int rightP = 0;
        int resultP = 0;
        
        while(leftP < left.length || rightP < right.length){
            if(leftP < left.length && rightP < right.length){
                if(left[leftP] < right[rightP]){}
            }
        }
        return result;
    }
}
