using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 16. 3Sum Closest
    /// Given an array S of n integers, find three integers in S such that the sum is closest
    /// to a given number, target. Return the sum of the three integers. You may assume that
    /// each input would have exactly one solution.
    ///
    /// For example, given array S = {-1 2 1 -4}, and target = 1.
    /// The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
    /// </summary>
    public class Problem_16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int Min = i + 1;
                int Max = nums.Length - 1;

                while (Max > Min)
                {
                    int tempsum = nums[i] + nums[Min] + nums[Max];

                    if (Math.Abs(target - tempsum) < Math.Abs(target - sum))
                    {
                        sum = tempsum;
                    }

                    if (target > tempsum) Min++;
                    else Max--;


                    if (sum == 0) break;
                }
            }
            return sum;
        }
    }
}
