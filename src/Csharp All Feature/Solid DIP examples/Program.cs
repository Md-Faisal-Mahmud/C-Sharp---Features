

static void Main(string[] args)
{



    int[] arr = { 1, 2, 3, 4, 5 };

    int target = 9;


}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {

                    return new int[] { i, j };
                }
            }
        }
        return null;

    }
}


