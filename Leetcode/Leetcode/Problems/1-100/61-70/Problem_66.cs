using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problems
{
    /// <summary>
    /// 66. Plus One
    /// Given a non-negative number represented as an array of digits, plus one to the number.
    /// The digits are stored such that the most significant digit is at the head of the list
    /// </summary>
    public class Problem_66
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> temp = new List<int>();
            digits[digits.Length - 1]++;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 10)
                {
                    temp.Add(digits[i]);
                }
                else
                {
                    temp.Add(0);

                    if (i == 0) temp.Add(1);
                    else digits[i - 1]++;
                }
            }
            temp.Reverse();
            return temp.ToArray<int>();
        }
    }
}
