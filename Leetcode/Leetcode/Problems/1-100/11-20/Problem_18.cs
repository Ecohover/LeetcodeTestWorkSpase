using System;
using System.Collections.Generic;

namespace Leetcode.Problems
{
    /// <summary>
    /// 18. 4Sum
    /// Given an array nums of n integers and an integer target, 
    /// are there elements a, b, c, and d in nums such that a + b + c + d = target? 
    /// Find all unique quadruplets in the array which gives the sum of target.
    /// </summary>
    public class Problem_18
    {
        public IList<IList<int>> FourSum2(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            return result;
        }

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, Dictionary<string, int[]>> dic3Sum = new Dictionary<int, Dictionary<string, int[]>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0) if (nums[i] == nums[i - 1]) continue;
                var sum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1) if (nums[j] == nums[j - 1]) continue;
                    sum = nums[i] + nums[j];
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (k > j + 1) if (nums[k] == nums[k - 1]) continue;
                        sum = nums[i] + nums[j] + nums[k];
                        if (!dic3Sum.ContainsKey(sum)) dic3Sum.Add(sum, new Dictionary<string, int[]>());
                        var key = $"{nums[i]},{nums[j]},{nums[k]}";
                        if (!dic3Sum[sum].ContainsKey(key)) dic3Sum[sum].Add(key, new int[3] { i, j, k });

                        for (int m = k + 1; m < nums.Length; m++)
                        {
                            if (m > k + 1) if (nums[m] == nums[m - 1]) continue;
                            var diff = target - nums[m];
                            if (dic3Sum.ContainsKey(diff))
                            {
                                var group = dic3Sum[diff];
                                foreach (var item in group.Keys)
                                {
                                    if (nums[m] >= nums[group[item][2]] && !group[item].Contains(m))
                                    {
                                        var temp = new List<int> { nums[group[item][0]], nums[group[item][1]], nums[group[item][2]], nums[m] };
                                        if (!result.Contains(temp))
                                        {
                                            result.Add(temp);
                                        }
                                    }
                                }
                                dic3Sum.Remove(diff);
                                break;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
