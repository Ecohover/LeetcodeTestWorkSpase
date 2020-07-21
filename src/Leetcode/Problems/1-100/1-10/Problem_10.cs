using Leetcode.Extension;
using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 10. Regular Expression Matching
    /// Implement regular expression matching with support for '.' and '*'.
    ///
    /// '.' Matches any single character.
    /// '*' Matches zero or more of the preceding element.
    ///
    /// The matching should cover the entire input string (not partial).
    ///
    /// The function prototype should be:
    /// bool isMatch(const char* s, const char* p)
    ///
    /// Some examples:
    /// isMatch("aa","a") → false
    /// isMatch("aa","aa") → true
    /// isMatch("aaa","aa") → false
    /// isMatch("aa", "a*") → true
    /// isMatch("aa", ".*") → true
    /// isMatch("ab", ".*") → true
    /// isMatch("aab", "c*a*b") → true
    /// </summary>
    public class Problem_10
    {
        public bool IsMatch(string s, string p)
        {
            bool Result = true;
            if (p.Length == 0 && s.Length == 0) Result = true;
            else if (p.Length == 0 && s.Length == 1) Result = false;
            else if (p.Length == 1 && s.Length == 0) Result = false;
            else if (p.Length == 1 && s.Length == 1) Result = (p[0] == s[0]) || p[0] == '.';
            else if (p.Length > 2)
            {

            }
            else
            {

            }
            return Result;
        }
    }
}
