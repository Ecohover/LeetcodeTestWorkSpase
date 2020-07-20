namespace Leetcode.Problems
{
    /// <summary>
    /// 136. Single Number
    /// Given an array of integers, every element appears twice except for one. Find that single one.
    /// 
    /// Note:
    /// Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

    /// </summary>
    public class Problem_136
    {
        public int SingleNumber(int[] nums)
        {
            int result = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }
# endre
    }
}
