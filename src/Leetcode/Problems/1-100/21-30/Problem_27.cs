namespace Leetcode.Problems
{
    /// <summary>
    /// 27. Remove Element
    /// Given an array and a value, remove all instances of that value in place and return the new length.
    /// Do not allocate extra space for another array, you must do this in place with constant memory.
    /// The order of elements can be changed. It doesn't matter what you leave beyond the new length.
    /// Example:
    /// Given input array nums = [3, 2, 2, 3], val = 3
    /// Your function should return length = 2, with the first two elements of nums being 2.
    /// </summary>
    public class Problem_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int Index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[Index] = nums[i];
                    Index++;
                }
            }
            return Index;
        }
    }
}
