namespace Leetcode.Problems
{
    /// <summary>
    /// 14. Longest Common Prefix
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// Subscribe to see which companies asked this question
    /// </summary>
    public class Problem_14
    {
        public string LongestCommonPrefix3(string[] strs)
        {
            string strResult = "";
            if (strs.Length == 0) return "";
            else if (strs.Length == 1) return strs[0];
            else strResult = "";
            for (int i = 0; i < strs.Length; i++)
            {



            }
            return strResult;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            string strResult = "";
            bool dowhile = true;
            int i = 1;
            if (strs.Length == 1)
            {
                strResult = strs[0];
            }
            else
            {
                while (dowhile)
                {
                    string strTempA = "";
                    string strTempB = "";
                    for (int j = 0; j < strs.Length - 1; j++)
                    {
                        if (strs[j].Length < i || strs[j + 1].Length < i)
                        {
                            dowhile = false;
                            break;
                        }
                        strTempA = strs[j].Substring(0, i);
                        strTempB = strs[j + 1].Substring(0, i);
                        if (strTempA != strTempB)
                        {
                            dowhile = false;
                            break;
                        }
                    }
                    if (dowhile) strResult = strTempA;
                    i++;
                }
            }

            return strResult;
        }
    }
}
