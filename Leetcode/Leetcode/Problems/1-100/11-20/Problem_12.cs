namespace Leetcode.Problems
{
    /// <summary>
    /// 12. Integer to Roman
    /// Given an integer, convert it to a roman numeral.
    /// Input is guaranteed to be within the range from 1 to 3999.
    /// </summary>
    public class Problem_12
    {
        public string IntToRoman(int num)
        {
            string strRoman = "";
            int[] intValue = new int[13] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] RomanValue = new string[13] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            for (int i = 12; i >= 0; i--)
            {
                while (num >= intValue[i])
                {
                    strRoman += RomanValue[i];
                    num -= intValue[i];
                }
            }
            return strRoman;
        }
    }
}
