using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 7. Reverse Integer
    /// Reverse digits of an integer.

    /// Example1: x = 123, return 321
    /// Example2: x = -123, return -321
    /// </summary>
    public class Problem_7
    {
        public int Reverse(int x)
        {
            int newx = 0;
            if (x < 10 && x > -10) return x;
            int sLength = Convert.ToString(x).Replace('-', ' ').Trim().Length;
            for (int i = sLength - 1; i >= 0; i--)
            {
                int temp = Convert.ToInt32(x / Convert.ToInt32(Math.Pow(10, i))
                    );
                x = x - temp * Convert.ToInt32(Math.Pow(10, i));

                try
                {
                    newx = checked(newx + temp * Convert.ToInt32(Math.Pow(10, sLength - i - 1)));
                }
                catch
                {
                    newx = 0;
                    break;
                }
            }
            return newx;
        }
        public int Reverse2(int x)
        {
            string temp;
            if (x < 10 && x > -10) return x;
            if (x < 0) temp = Convert.ToString(0 - x);
            else temp = Convert.ToString(x);
            temp = Convert.ToString(x).Replace('-', '\0').Trim();
            char[] arytemp = temp.ToCharArray();
            char chartemp;
            for (int i = 0; i < Math.Floor(Convert.ToDouble(arytemp.Length / 2)); i++)
            {
                chartemp = arytemp[i];
                arytemp[i] = arytemp[arytemp.Length - i - 1];
                arytemp[arytemp.Length - i - 1] = chartemp;
            }
            temp = new string(arytemp);

            if (x < 0) temp = "-" + temp;
            try
            {
                x = Convert.ToInt32(temp);
            }
            catch
            {
                x = 0;
            }
            return x;
        }
    }
}
