namespace Leetcode.Problems
{
    /// <summary>
    /// 20. Valid Parentheses
    /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']',
    /// determine if the input string is valid.
    /// The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
    /// Subscribe to see which companies asked this question
    /// </summary>
    public class Problem_20
    {
        public bool IsValid(string s)
        {
            while (true)
            {
                string stemp = s;
                stemp = stemp.Replace("()", "").Replace("[]", "").Replace("{}", "");
                if (stemp != s) s = stemp;
                else break;
            }
            if (s == "") return true;
            else return false;
        }
    }
}
