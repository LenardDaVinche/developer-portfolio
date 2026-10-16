public class Exercise2
{
    public int array1[][]= {{1,2,3}, {1,2,3}, {1,2,3}};
    public int array2[][]= {{1,2,3}, {1,2,3}, {1,2,3}};
    
    public Exercise2()
    {
        printAll(sum(array1, array2));
    }
    
    public int[][] sum(int[][] array1, int[][] array2)
    {
        int array[][] = new int[array1.length][array1[0].length];
        for(int i=0; i<array1.length; i++)
        {
            for(int j=0; j<array1.length; j++){
                array[i][j]=array1[i][j]+array2[i][j];
            }
        }
        return array;
    }

    public void printAll(int[][] array)
    {
        for(int i=0; i<array.length; i++)
        {
            for(int j=0; j<array[0].length; j++){
                System.out.print(array[i][j]+"");
            }
            System.out.println("");
        }
    }
}