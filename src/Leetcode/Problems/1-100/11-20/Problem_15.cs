using System;
using System.Collections.Generic;
namespace Leetcode.Problems
{
    /// <summary>
    /// 15. 3Sum
    /// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0?
    /// Find all unique triplets in the array which gives the sum of zero.
    /// Note:
    /// Elements in a triplet(a, b, c) must be in non-descending order. (ie, a ≤ b ≤ c)
    /// The solution set must not contain duplicate triplets.
    /// </summary>
    public class Problem_15
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<string> ThreeSummKeyList = new List<string>();
            List<List<int>> ThreeSumlist = new List<List<int>>();
            if (nums.Length < 3) return (List<List<int>>)ThreeSumlist;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int Min = i + 1;
                    int Max = nums.Length - 1;
                    int Target = 0 - nums[i];
                    while (Min < Max)
                    {
                        if (Target == nums[Max] + nums[Min])
                        {
                            AddList(ThreeSummKeyList, ThreeSumlist, new int[] { nums[i], nums[Min], nums[Max] });
                            while (Min < Max && nums[Min] == nums[Min + 1]) Min++;
                            while (Min < Max && nums[Max] == nums[Max - 1]) Max--;
                            Min++;
                            Max--;
                        }
                        else if (nums[Min] + nums[Max] < Target) Min++;
                        else Max--;
                    }
                }
            }

            return (List<List<int>>)ThreeSumlist;
        }
        public List<List<int>> AddList(List<string> ThreeSummKeyList, List<List<int>> lists, int[] Addlist)
        {
            string key = Addlist[0] + "," + Addlist[1] + "," + Addlist[2];
            if (!ThreeSummKeyList.Contains(key))
            {
                lists.Add(new List<int> { Addlist[0], Addlist[1], Addlist[2] });
                ThreeSummKeyList.Add(key);
            }
            return lists;
        }
    }
}
