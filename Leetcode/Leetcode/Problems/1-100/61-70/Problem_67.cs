using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 67. Add Binary
    /// Given two binary strings, return their sum (also a binary string).
    /// For example,
    /// a = "11"
    /// b = "1"
    /// Return "100".
    /// </summary>
    public class Problem_67
    {
        public string AddBinary(string a, string b)
        {
            if (a.Length < b.Length)
            {
                string T = a;
                a = b;
                b = T;
            }
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                int aLocation = a.Length - 1 - i;
                int bLocation = b.Length - 1 - i;
                if (b.Length > i)
                {
                    sum = Convert.ToInt16(Convert.ToString(a[aLocation])) + Convert.ToInt16(Convert.ToString(b[bLocation]));
                }

                if (sum % 2 == 0)
                {
                    a = a.Substring(0, aLocation) + "0" + a.Substring(aLocation + 1, a.Length - (aLocation + 1));
                }
                else
                {
                    a = a.Substring(0, aLocation) + "1" + a.Substring(aLocation + 1, a.Length - (aLocation + 1));
                }

                if (sum / 2 == 1)
                {
                    if (a.Length == aLocation - 1)
                    {
                        a = "1" + a;
                    }
                    else
                    {

                        a = a.Substring(0, aLocation - 1) +
                            Convert.ToString(Convert.ToInt16(Convert.ToString(a[aLocation - 1])) + 1) +
                            a.Substring(aLocation, a.Length - (aLocation + 1));
                    }
                }
            }
            return a;
        }
    }
}
