using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 5. Longest Palindromic Substring
    /// Given a string S, find the longest palindromic substring in S.
    /// You may assume that the maximum length of S is 1000,
    /// and there exists one unique longest palindromic substring.
    /// </summary>
    public class Problem_5
    {
        int StartIndex;
        int EndIndex;
        int MaxLength;
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;
            if (s.Length < 2) return s[0].ToString();
            StartIndex = 0;
            EndIndex = 0;
            MaxLength = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                CheckPalindrome(s, i, i + 1);
                CheckPalindrome(s, i - 1, i + 1);
            }
            return s.Substring(StartIndex, EndIndex - StartIndex + 1);
        }
        public void CheckPalindrome(string s, int x, int y)
        {
            while (x >= 0 && y < s.Length && s[x] == s[y])
            {
                x--;
                y++;
            }
            int TempMax = y - x + 1;
            if (TempMax > MaxLength)
            {
                MaxLength = TempMax;
                StartIndex = x + 1;
                EndIndex = y - 1;
            }
        }
    }
}
