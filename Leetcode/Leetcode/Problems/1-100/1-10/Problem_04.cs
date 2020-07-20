using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 4. Median of Two Sorted Arrays
    /// Given a string, find the length of the longest substring without repeating characters.
    /// For example, the longest substring without repeating letters for "abcabcbb" is "abc", which the length is 3.
    /// For "bbbbb" the longest substring is "b", with the length of 1.
    /// </summary>
    public class Problem_4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int Index1 = 0;
            int Index2 = 0;
            int TotalLength = nums1.Length + nums2.Length;
            bool isOdd = (((TotalLength) % 2) == 0) ? false : true;
            int TargetIndex = TotalLength / 2 + 1;
            int[] SortedArray = new int[TargetIndex];
            while (TargetIndex > (Index1 + Index2))
            {
                if (Index1 < nums1.Length && Index2 < nums2.Length)
                {
                    if (nums1[Index1] >= nums2[Index2])
                    {
                        SortedArray[Index1 + Index2] = nums2[Index2];
                        Index2++;
                    }
                    else
                    {
                        SortedArray[Index1 + Index2] = nums1[Index1];
                        Index1++;
                    }

                }
                else if (Index1 >= nums1.Length && Index2 < nums2.Length)
                {
                    SortedArray[Index1 + Index2] = nums2[Index2];
                    Index2++;
                }
                else if (Index1 < nums1.Length && Index2 >= nums2.Length)
                {
                    SortedArray[Index1 + Index2] = nums1[Index1];
                    Index1++;
                }
            }


            return isOdd ? Convert.ToDouble(SortedArray[TargetIndex - 1]) : Convert.ToDouble((SortedArray[TargetIndex - 1] + SortedArray[TargetIndex - 2])) / 2;
        }
    }
}
