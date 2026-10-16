
public class Recursion
{
    public int getFactorial(int n)
    {
        if (n < 2){
            return 1;
        }else{
            return n * getFactorial(n-1);
        }
    }
    
    public void usingLoop(){
        int factorial = 1;
        for(int i = 1; i<=5; i++){
            factorial = factorial * i;  
        }
        System.out.println("Factorial : "+ factorial);
    }
}