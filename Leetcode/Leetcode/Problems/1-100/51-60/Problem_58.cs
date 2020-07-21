namespace Leetcode.Problems
{
    /// <summary>
    /// 58. Length of Last Word
    /// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
    /// If the last word does not exist, return 0.
    /// Note: A word is defined as a character sequence consists of non-space characters only.
    /// For example,
    /// Given s = "Hello World",
    /// </summary>
    public class Problem_58
    {
        public int LengthOfLastWord(string s)
        {
            string[] strarray = s.Trim().Split(' ');
            return strarray[strarray.Length - 1].Length;
        }
    }
}
