namespace Leetcode.Problems
{
    /// <summary>
    /// 28. Implement
    /// Implement strStr().
    /// Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// Subscribe to see which companies asked this question
    /// </summary>
    public class Problem_28
    {
        public int StrStr(string haystack, string needle)
        {
            int Result = -1;
            if (needle == "") return 0;
            if (needle.Length > haystack.Length) return -1;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle) return i;
            }
            return Result;
        }
    }
}
