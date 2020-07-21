using System;
using System.Collections.Generic;
using Leetcode.Enumerate;

namespace Leetcode.Problems
{
    /// <summary>
    /// 13. Roman to Integer
    /// Given a roman numeral, convert it to an integer.
    /// Input is guaranteed to be within the range from 1 to 3999.
    /// 1234 MCCXXXIV
    /// </summary>
    public class Problem_13
    {
        public int RomanToInt(string s)
        {
            int intResult = 0;
            char[] charRoman = s.ToCharArray();
            int intOld = 0;
            int intNew = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("I", 1);
            dic.Add("V", 5);
            dic.Add("X", 10);
            dic.Add("L", 50);
            dic.Add("C", 100);
            dic.Add("D", 500);
            dic.Add("M", 1000);
            for (int i = charRoman.Length - 1; i >= 0; i--)
            {
                intNew = dic[charRoman[i].ToString()];
                if (intNew >= intOld) intResult += intNew;
                else intResult -= intNew;

                intOld = intNew;
            }

            return intResult;
        }

        public int RomanToInt2(string s)
        {
            int intResult = 0;
            char[] charRoman = s.ToCharArray();
            int intOld = 0;
            int intNew = 0;
            for (int i = charRoman.Length - 1; i >= 0; i--)
            {
                intNew = (int)((EnumRoman)Enum.Parse(typeof(EnumRoman), charRoman[i].ToString(), false));
                if (intNew >= intOld) intResult += intNew;
                else intResult -= intNew;

                intOld = intNew;
            }


            return intResult;
        }
    }
}
