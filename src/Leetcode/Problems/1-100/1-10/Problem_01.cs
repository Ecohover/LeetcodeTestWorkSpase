using System.Collections.Generic;

namespace Leetcode.Problems
{
    /// <summary>
    /// 1. TwoSum
    /// Given an array of integers, find two numbers such that they add up to a specific target number.
    /// The function twoSum should return indices of the two numbers such that they add up to the target,
    /// where index1 must be less than index2.Please note that your returned answers(both index1 and index2) are not zero-based.
    /// You may assume that each input would have exactly one solution.
    /// Input: numbers={2, 7, 11, 15}, target=9
    /// Output: index1=0, index2=1
    /// </summary>
    public class Problem_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int Num1 = nums[i];
                int Num2 = target - Num1;
                if (dic.ContainsKey(Num2)) return (new int[] { dic[Num2], i });
                if (!dic.ContainsKey(Num1)) dic.Add(Num1, i);
            }
            return new int[] { 0, 0 };
        }
    }
}
