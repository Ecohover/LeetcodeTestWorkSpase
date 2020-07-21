﻿using System.Linq;

namespace Leetcode.Problems
{
    /// <summary>
    /// 35. Search Insert Position
    /// Given a sorted array and a target value, return the index if the target is found. If not, 
    /// return the index where it would be if it were inserted in order.
    /// You may assume no duplicates in the array.
    /// Example 1:
    /// Input: [1,3,5,6], 5
    /// Output: 2
    /// Example 2:
    /// Input: [1,3,5,6], 2
    /// Output: 1
    /// Example 3:
    /// Input: [1,3,5,6], 7
    /// Output: 4
    /// Example 4:
    /// Input: [1,3,5,6], 0
    /// Output: 0
    /// </summary>
    public class Problem_35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int maxlenght = nums.Count();
            int min = 0;
            int max = maxlenght - 1;
            int cut = GetCut(max, min);
            if (nums[max] < target) return max + 1;
            else if (nums[min] >= target) return min;
            while (max - min > 1)
            {
                if (target > nums[cut]) min = cut;
                else max = cut;
                cut = GetCut(max, min);
            }
            return min + 1;
        }

        private int GetCut(int max, int min)
        {
            return ((min + max) / 2);
        }
    }
}
