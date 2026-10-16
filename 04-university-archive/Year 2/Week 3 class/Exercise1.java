public class Exercise1
{
    private int nums[] = {20, 20, 30, 40, 50, 50, 50};

    public void printAll()
    {
        for (int n : nums)
        {
            System.out.print("|" + n + "|");
        }
        System.out.println("");
        System.out.println(nums.length);
        removeDupe();
        System.out.println("");
    }

    public void removeDupe()
    {
        int dupe = 0;
        for(int i=0; i < nums.length-1; i++)
        {
            if(nums[i] == nums[i+1])
            {
                dupe++;
            }
        }
        System.out.println(dupe);
        int elim[] = new int[nums.length - dupe];

        int x = 0;
        int count = 0;

        for(int i=0; i < nums.length; i++)
        {
            if(x != nums[i])
            {
                elim[count] = nums[i];
                count++;
                x = nums[i];
            }
        }

        for (int i : elim)
        {
            System.out.print("|" + i + "|");
        }
    }
}