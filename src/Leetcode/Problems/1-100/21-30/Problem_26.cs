namespace Leetcode.Problems
{
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// Given a sorted array, remove the duplicates in place such that each element
    /// appear only once and return the new length.
    /// Do not allocate extra space for another array, you must do this in place with constant memory.
    /// For example,
    /// Given input array nums = [1, 1, 2],
    /// Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
    /// It doesn't matter what you leave beyond the new length.
    /// </summary>
    public class Problem_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            int Index = 0;
            for (int Pick = 1; Pick < nums.Length; Pick++)
            {
                if (nums[Index] != nums[Pick])
                {
                    Index++;
                    nums[Index] = nums[Pick];
                }
            }
            return Index + 1;
        }
    }
}
