
namespace Leetcode.Problems
{
    /// <summary>
    /// 125. Valid Palindrome
    /// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    /// 
    /// For example,
    /// "A man, a plan, a canal: Panama" is a palindrome.
    /// "race a car" is not a palindrome.
    /// 
    /// Note:
    /// Have you consider that the string might be empty? This is a good question to ask during an interview.
    /// For the purpose of this problem, we define empty string as valid palindrome.
    /// </summary>
    public class Problem_125
    {
        public bool IsPalindrome(string s)
        {
            string list = "abcdefghijklmnopqrstuvwxyz1234567890";
            for (int i = 0, j = s.Length - 1; i < j;)
            {

                if (!list.Contains(s[i].ToString().ToLower())) i++;
                if (!list.Contains(s[j].ToString().ToLower())) j--;
                if (list.Contains(s[i].ToString().ToLower()) && list.Contains(s[j].ToString().ToLower()))
                {

                    if (s[i].ToString().ToLower() != s[j].ToString().ToLower()) return false;
                    else
                    {
                        i++;
                        j--;
                    }
                }

            }
            return true;
        }
    }
}
