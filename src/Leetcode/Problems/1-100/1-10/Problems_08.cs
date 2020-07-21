using Leetcode.Extension;
using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 8. String to Integer (atoi)
    /// Implement atoi to convert a string to an integer.
    ///
    /// Hint: Carefully consider all possible input cases.
    /// If you want a challenge, please do not see below and ask yourself what are the possible input cases.
    ///
    /// Notes: It is intended for this problem to be specified vaguely (ie, no given input specs).
    /// You are responsible to gather all the input requirements up front.
    ///
    /// </summary>
    public class Problem_8
    {
        public int MyAtoi(string str)
        {
            str = str.Trim();
            string temp = "";
            int intResult = 0;
            try
            {
                if (str.Length == 0) return 0;
                if (str[0].CheckSign())
                {
                    if (str.Length == 1) return 0;
                    if (!str[1].CheckInt()) return 0;
                    else temp = str[0].ToString();
                }
                else if (str[0].CheckInt())
                {
                    temp = str[0].ToString();
                }
                else
                {
                    return 0;
                }


                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i].CheckInt())
                    {
                        temp = temp + str[i];
                    }
                    else
                    {
                        break;
                    }
                }
                intResult = checked(Convert.ToInt32(temp));
                //2147483647
                //-2147483648
            }
            catch
            {
                if (str[0] == '-') intResult = -2147483648;
                else intResult = 2147483647;
            }
            return intResult;
        }
    }
}
