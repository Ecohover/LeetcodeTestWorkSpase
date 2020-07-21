using Leetcode.Extension;
using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 9. Palindrome Number
    /// Determine whether an integer is a palindrome. Do this without extra space.
    /// </summary>
    public class Problem_9
    {
        public bool IsPalindrome(int x)
        {
            int Temp = 0;
            if (x < 0 || (x % 10 == 0 && x >= 10)) return false;
            if (x < 10) return true;
            while (true)
            {
                Temp = Temp * 10 + (x % 10);
                if (Temp == x) return true;
                x = x / 10;
                if (Temp == x) return true;
                if (x == 0) break;
            }
            return false;
        }
    }
}
