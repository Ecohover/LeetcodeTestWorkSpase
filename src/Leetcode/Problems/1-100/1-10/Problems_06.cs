using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 6. ZigZag Conversion
    /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this:
    /// (you may want to display this pattern in a fixed font for better legibility)
    ///   P   A   H   N
    ///   A P L S I I G
    ///   Y   I   R
    /// And then read line by line: "PAHNAPLSIIGYIR"
    /// Write the code that will take a string and make this conversion given a number of rows:
    /// string convert(string text, int nRows);
    /// convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
    /// </summary>
    public class Problem_6
    {
        public string Convert2(string s, int numRows)
        {
            if (numRows == 1) return s;
            string NewString = "";
            int GroupsSize = (numRows - 1) * 2;

            int FirstIndex;
            int SecondIndex;
            for (int Row = 0; Row < numRows; Row++)
            {
                for (int GroupNum = 0; Row + (GroupsSize * GroupNum) < s.Length; GroupNum++)
                {
                    FirstIndex = Row + (GroupsSize * GroupNum);
                    NewString += s[FirstIndex];
                    if (Row != 0 && Row != numRows - 1)
                    {
                        SecondIndex = FirstIndex + GroupsSize - Row * 2;
                        if (SecondIndex < s.Length) NewString += s[SecondIndex];
                    }
                }
            }
            return NewString;

        }

        public string Convert1(string s, int numRows)
        {
            if (numRows == 1) return s;
            char[] Newchar = new char[s.Length];
            int GroupsSize = (numRows - 1) * 2;
            int sRemainder = s.Length % GroupsSize;
            int sFloor = s.Length / GroupsSize;

            for (int i = 0; i < s.Length; i++)
            {
                int iRemainder = i % GroupsSize;
                int iFloor = i / GroupsSize;
                int NewIndex = 0;
                //if ()
                Newchar[NewIndex] = s[i];
            }
            return Newchar.ToString();

        }
    }
}
