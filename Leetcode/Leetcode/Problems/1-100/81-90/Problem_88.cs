namespace Leetcode.Problems
{
    /// <summary>
    /// 88. Merge Sorted Array
    /// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
    /// Note:
    /// You may assume that nums1 has enough space (size that is greater or equal to m + n) 
    /// to hold additional elements from nums2. The number of elements initialized in nums1 and nums2 
    /// are m and n respectively.
    /// </summary>
    public class Problem_88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i >= 0 && n > 0; i--)
            {
                if (m == 0) nums1[i] = nums2[--n];
                else
                {
                    if (nums1[m - 1] < nums2[n - 1]) nums1[i] = nums2[--n];
                    else nums1[i] = nums1[--m];
                }
            }

        }
    }
}
