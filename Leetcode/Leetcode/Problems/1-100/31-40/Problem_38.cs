namespace Leetcode.Problems
{
    /// <summary>
    /// 38. Count and Say
    /// The count-and-say sequence is the sequence of integers beginning as follows:
    /// 1, 11, 21, 1211, 111221, 312211,...
    /// 1 is read off as "one 1" or 11.
    /// 11 is read off as "two 1s" or 21.
    /// 21 is read off as "one 2, then one 1" or 1211.
    /// Given an integer n, generate the nth sequence.
    /// Note: The sequence of integers will be represented as a string.
    /// </summary>
    public class Problem_38
    {
        public string CountAndSay(int n)
        {
            string s = "1";

            for (int i = 1; i < n; i++)
            {
                int j = 0;
                string temps = "";
                string Currtemps = "";
                int pick = 0;
                for (; pick < s.Length; pick++)
                {
                    if (s[pick] == s[j])
                    {
                        Currtemps = (pick - j + 1).ToString() + s[pick];
                    }
                    else
                    {
                        temps += Currtemps;
                        Currtemps = "1" + s[pick];
                        j = pick;
                    }
                }
                if (j != pick)
                {
                    temps += Currtemps;
                }
                s = temps;
            }
            return s;
        }
    }
}
