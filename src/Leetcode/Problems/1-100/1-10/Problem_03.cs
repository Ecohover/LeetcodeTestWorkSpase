using System;
using System.Collections.Generic;

namespace Leetcode.Problems
{
    /// <summary>
    /// 3. Longest Substring Without Repeating Characters
    /// Given a string, find the length of the longest substring without repeating characters.
    /// For example, the longest substring without repeating letters for "abcabcbb" is "abc", which the length is 3.
    /// For "bbbbb" the longest substring is "b", with the length of 1.
    /// </summary>
    public class Problem_3
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int Max = 0;
            int TempMax;
            int LastDuplicateIndex = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                TempMax = Max;
                string Pick = s.Substring(i, 1);
                if (dic.ContainsKey(Pick))
                {
                    LastDuplicateIndex = Math.Max(dic[Pick] + 1, LastDuplicateIndex);
                    dic[Pick] = i;
                }
                else
                {
                    dic.Add(Pick, i);
                }
                Max = Math.Max(Max, i - LastDuplicateIndex + 1);
            }
            return Max;
        }
    }
}
