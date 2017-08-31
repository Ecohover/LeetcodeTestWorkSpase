using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CodeArea
    {

        public CodeArea()
        {

        }
        #region 1. TwoSum
        /// <summary>
        /// Given an array of integers, find two numbers such that they add up to a specific target number.
        /// The function twoSum should return indices of the two numbers such that they add up to the target,
        /// where index1 must be less than index2.Please note that your returned answers(both index1 and index2) are not zero-based.
        /// You may assume that each input would have exactly one solution.
        /// Input: numbers={2, 7, 11, 15}, target=9
        /// Output: index1=0, index2=1
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            //int[] temp = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int Num1 = nums[i];
                int Num2 = target - Num1;
                if (dic.ContainsKey(Num2)) return (new int[] { dic[Num2], i });
                if (!dic.ContainsKey(Num1)) dic.Add(Num1, i);
            }
            return new int[] { 0, 0 };

        }

        #endregion

        #region 2. Add Two Numbers
        /// <summary>
        /// You are given two linked lists representing two non-negative numbers.
        /// The digits are stored in reverse order and each of their nodes contain a single digit.
        /// Add the two numbers and return it as a linked list.
        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 != null && l2 != null)
            {
                l1.val += l2.val;

                if (l1.val >= 10 || l1.next != null || l2.next != null)
                {
                    if (l1.next == null) l1.next = new ListNode(0);
                    if (l2.next == null) l2.next = new ListNode(0);
                    l1.next.val += l1.val / 10;
                    l1.val = l1.val % 10;
                }

                AddTwoNumbers(l1.next, l2.next);
            }
            return l1;
        }

        #endregion

        #region 3. Longest Substring Without Repeating Characters
        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters.
        /// For example, the longest substring without repeating letters for "abcabcbb" is "abc", which the length is 3.
        /// For "bbbbb" the longest substring is "b", with the length of 1.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int Max = 0;
            int TempMax;
            int LastDuplicateIndex = 0;
            int TempDuplicateIndex = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                TempMax = Max;
                string Pick = s.Substring(i, 1);
                if (dic.ContainsKey(Pick))
                {
                    LastDuplicateIndex = Math.Max(dic[Pick] + 1, LastDuplicateIndex);
                    dic[Pick] = i;
                }
                else
                {
                    dic.Add(Pick, i);
                }
                Max = Math.Max(Max, i - LastDuplicateIndex + 1);
            }
            return Max;
        }

        #endregion

        #region 4. Median of Two Sorted Arrays
        /// <summary>
        /// There are two sorted arrays nums1 and nums2 of size m and n respectively.
        /// Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int Min1 = 0;
            int Min2 = 0;
            int TotalLength = nums1.Length + nums2.Length;
            bool isOdd = (((TotalLength) % 2) == 0) ? false : true;
            int Target = TotalLength / 2 + 1;
            int[] TNum = new int[Target];
            while (Target > (Min1 + Min2))
            {
                if (Min1 < nums1.Length && Min2 < nums2.Length)
                {
                    if (nums1[Min1] >= nums2[Min2])
                    {
                        TNum[Min1 + Min2] = nums2[Min2];
                        Min2++;
                    }
                    else
                    {
                        TNum[Min1 + Min2] = nums1[Min1];
                        Min1++;
                    }

                }
                else if (Min1 >= nums1.Length && Min2 < nums2.Length)
                {
                    TNum[Min1 + Min2] = nums2[Min2];
                    Min2++;
                }
                else if (Min1 < nums1.Length && Min2 >= nums2.Length)
                {
                    TNum[Min1 + Min2] = nums1[Min1];
                    Min1++;
                }
                else
                {

                }

            }


            return isOdd ? Convert.ToDouble(TNum[Target - 1]) : Convert.ToDouble((TNum[Target - 1] + TNum[Target - 2])) / 2;
        }



        #endregion

        #region 5. Longest Palindromic Substring
        /// <summary>
        /// Given a string S, find the longest palindromic substring in S.
        /// You may assume that the maximum length of S is 1000,
        /// and there exists one unique longest palindromic substring.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            if (s.Length < 2) return s[0].ToString();
            StartIndex = 0;
            EndIndex = 0;
            MaxLength = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                CheckPalindrome(s, i, i + 1);
                CheckPalindrome(s, i - 1, i + 1);
            }
            return s.Substring(StartIndex, EndIndex - StartIndex + 1);
        }

        int StartIndex;
        int EndIndex;
        int MaxLength;
        public void CheckPalindrome(string s, int x, int y)
        {
            while (x >= 0 && y < s.Length && s[x] == s[y])
            {
                x--;
                y++;
            }
            int TempMax = y - x + 1;
            if (TempMax > MaxLength)
            {
                MaxLength = TempMax;
                StartIndex = x + 1;
                EndIndex = y - 1;
            }
        }
        #endregion

        #region 6. ZigZag Conversion
        /// <summary>
        /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this:
        /// (you may want to display this pattern in a fixed font for better legibility)
        ///   P   A   H   N
        ///   A P L S I I G
        ///   Y   I   R
        ///And then read line by line: "PAHNAPLSIIGYIR"
        ///Write the code that will take a string and make this conversion given a number of rows:
        ///string convert(string text, int nRows);
        ///        convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
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
        #endregion

        #region 7. Reverse Integer
        /// <summary>
        /// Reverse digits of an integer.

        ///Example1: x = 123, return 321
        ///Example2: x = -123, return -321
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
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
        #endregion

        #region 8. String to Integer (atoi)
        /// <summary>
        /// Implement atoi to convert a string to an integer.
        ///
        ///Hint: Carefully consider all possible input cases.
        /// If you want a challenge, please do not see below and ask yourself what are the possible input cases.
        ///
        ///Notes: It is intended for this problem to be specified vaguely (ie, no given input specs).
        /// You are responsible to gather all the input requirements up front.
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int MyAtoi(string str)
        {
            str = str.Trim();
            string temp = "";
            int intResult = 0;
            try
            {
                if (str.Length == 0) return 0;
                if (CheckSign(str[0]))
                {
                    if (str.Length == 1) return 0;
                    if (!CheckInt(str[1])) return 0;
                    else temp = str[0].ToString();
                }
                else if (CheckInt(str[0]))
                {
                    temp = str[0].ToString();
                }
                else
                {
                    return 0;
                }


                for (int i = 1; i < str.Length; i++)
                {
                    if (CheckInt(str[i]))
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

        public bool CheckInt(char chr)
        {
            bool Result = false;
            if (chr == '0' || chr == '1' || chr == '2' || chr == '3' || chr == '4'
              || chr == '5' || chr == '6' || chr == '7' || chr == '8' || chr == '9')
            {
                Result = true;
            }
            return Result;
        }

        public bool CheckSign(char chr)
        {
            bool Result = false;
            if (chr == '-' || chr == '+') Result = true;
            return Result;
        }


        #endregion

        #region 9. Palindrome Number
        /// <summary>
        /// Determine whether an integer is a palindrome. Do this without extra space.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            int Temp = 0;
            if (x < 0 || (x % 10 == 0 && x >= 10)) return false;
            if (x < 10) return true;
            while (true)
            {
                Temp = Temp * 10 + (x % 10);
                if (Temp == x) return true;
                x = x / 10;
                if (Temp == x) return true;
                if (x == 0) break;
            }
            return false;
        }
        #endregion

        #region 10. Regular Expression Matching
        /// <summary>
        /// Implement regular expression matching with support for '.' and '*'.
        ///
        /// '.' Matches any single character.
        /// '*' Matches zero or more of the preceding element.
        ///
        /// The matching should cover the entire input string (not partial).
        ///
        /// The function prototype should be:
        /// bool isMatch(const char* s, const char* p)
        ///
        /// Some examples:
        /// isMatch("aa","a") → false
        /// isMatch("aa","aa") → true
        /// isMatch("aaa","aa") → false
        /// isMatch("aa", "a*") → true
        /// isMatch("aa", ".*") → true
        /// isMatch("ab", ".*") → true
        /// isMatch("aab", "c*a*b") → true
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            if (s == "" && p == "") return true;
            if (p.Length >= 2)
            {
                if (p[1] == '*')
                {

                }
                else
                {

                }


            }
            else
            {
            }


            return false;
        }
        #endregion

        #region 11. Container With Most Water
        /// <summary>
        /// Given n non-negative integers a1, a2, ..., an,
        /// where each represents a point at coordinate (i, ai).
        /// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0).
        /// Find two lines, which together with x-axis forms a container,
        /// such that the container contains the most water.

        ///Note: You may not slant the container.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            int MaxArea = 0;
            int Right = height.Length - 1;
            int Left = 0;
            int TempH = 0;
            int TempW = 0;
            int TempArea = 0;
            while (true)
            {
                TempH = height[Right] > height[Left] ? height[Left] : height[Right];
                TempW = Right - Left;
                TempArea = TempH * TempW;
                MaxArea = MaxArea > TempArea ? MaxArea : TempArea;
                if (height[Right] > height[Left])
                {
                    Left++;
                }
                else
                {
                    Right--;
                }
                if (TempW <= 0) break;
            }
            return MaxArea;
        }
        #endregion

        #region 12. Integer to Roman
        /// <summary>
        /// Given an integer, convert it to a roman numeral.
        /// Input is guaranteed to be within the range from 1 to 3999.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
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
        #endregion

        #region 13. Roman to Integer
        /// <summary>
        /// Given a roman numeral, convert it to an integer.
        /// Input is guaranteed to be within the range from 1 to 3999.
        /// 1234 MCCXXXIV
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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
                intNew = (int)((Roman)Enum.Parse(typeof(Roman), charRoman[i].ToString(), false));
                if (intNew >= intOld) intResult += intNew;
                else intResult -= intNew;

                intOld = intNew;
            }


            return intResult;
        }
        public enum Roman : int
        {
            I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000
        }
        #endregion

        #region 14. Longest Common Prefix
        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// Subscribe to see which companies asked this question
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
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
        #endregion

        #region 15. 3Sum
        /// <summary>
        /// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0?
        /// Find all unique triplets in the array which gives the sum of zero.
        /// Note:
        /// Elements in a triplet(a, b, c) must be in non-descending order. (ie, a ≤ b ≤ c)
        /// The solution set must not contain duplicate triplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<string> ThreeSummKeyList = new List<string>();
            List<List<int>> ThreeSumlist = new List<List<int>>();
            if (nums.Length < 3) return (List<List<int>>)ThreeSumlist;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int Min = i + 1;
                    int Max = nums.Length - 1;
                    int Target = 0 - nums[i];
                    while (Min < Max)
                    {
                        if (Target == nums[Max] + nums[Min])
                        {
                            AddList(ThreeSummKeyList, ThreeSumlist, new int[] { nums[i], nums[Min], nums[Max] });
                            while (Min < Max && nums[Min] == nums[Min + 1]) Min++;
                            while (Min < Max && nums[Max] == nums[Max - 1]) Max--;
                            Min++;
                            Max--;
                        }
                        else if (nums[Min] + nums[Max] < Target) Min++;
                        else Max--;
                    }
                }
            }

            return (List<List<int>>)ThreeSumlist;
        }
        public List<List<int>> AddList(List<string> ThreeSummKeyList, List<List<int>> lists, int[] Addlist)
        {
            string key = Addlist[0] + "," + Addlist[1] + "," + Addlist[2];
            if (!ThreeSummKeyList.Contains(key))
            {
                lists.Add(new List<int> { Addlist[0], Addlist[1], Addlist[2] });
                ThreeSummKeyList.Add(key);
            }
            return lists;
        }
        #endregion

        #region 16. 3Sum Closest
        /// <summary>
        /// Given an array S of n integers, find three integers in S such that the sum is closest
        /// to a given number, target. Return the sum of the three integers. You may assume that
        /// each input would have exactly one solution.
        ///
        /// For example, given array S = {-1 2 1 -4}, and target = 1.
        /// The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int diff = 0;
            int sum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int Min = i + 1;
                int Max = nums.Length - 1;

                while (Max > Min)
                {
                    int tempsum = nums[i] + nums[Min] + nums[Max];

                    if (Math.Abs(target - tempsum) < Math.Abs(target - sum))
                    {
                        sum = tempsum;
                    }

                    if (target > tempsum) Min++;
                    else Max--;


                    if (sum == 0) break;
                }
            }
            return sum;
        }
        #endregion

        #region 19. Remove Nth Node From End of List
        /// <summary>
        /// Given a linked list, remove the nth node from the end of list and return its head.
        /// For example,
        /// Given linked list: 1->2->3->4->5, and n = 2.
        /// After removing the second node from the end, the linked list becomes 1->2->3->5.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode objResult;
            if (head.next != null)
            {
                head.next = RemoveNthFromEnd(head.next, n);
                NodeLocation++;
            }
            else
            {
                NodeLocation = 1;
            }

            if (NodeLocation == n)
            {
                if (head.next != null) objResult = head.next;
                else objResult = null;
            }
            else
            {
                objResult = head;
            }
            return objResult;
        }
        public int NodeLocation = 0;
        #endregion

        #region 20. Valid Parentheses
        /// <summary>
        /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']',
        /// determine if the input string is valid.
        /// The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
        /// Subscribe to see which companies asked this question
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

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
        #endregion

        #region 21. Merge Two Sorted Lists
        /// <summary>
        /// Merge two sorted linked lists and return it as a new list.
        /// The new list should be made by splicing together the nodes of the first two lists.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode NewNode = null;

            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val)
            {
                NewNode = l1;
                NewNode.next = MergeTwoLists(l1.next, l2);
            }
            else
            {
                NewNode = l2;
                NewNode.next = MergeTwoLists(l1, l2.next);
            }

            return NewNode;
        }
        #endregion

        #region 24. Swap Nodes in Pairs
        /// <summary>
        /// Given a linked list, swap every two adjacent nodes and return its head.
        /// For example,
        /// Given 1->2->3->4, you should return the list as 2->1->4->3.
        /// Your algorithm should use only constant space.You may not modify the values in the list,
        /// only nodes itself can be changed.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairs(ListNode head)
        {
            int tempval = 0;
            if (head == null) return null;
            if (head.next != null)
            {
                tempval = head.val;
                head.val = head.next.val;
                head.next.val = tempval;

                if (head.next.next != null)
                {
                    head.next.next = SwapPairs(head.next.next);
                }
            }
            return head;
        }
        #endregion

        #region 26. Remove Duplicates from Sorted Array
        /// <summary>
        /// Given a sorted array, remove the duplicates in place such that each element
        /// appear only once and return the new length.
        /// Do not allocate extra space for another array, you must do this in place with constant memory.
        /// For example,
        /// Given input array nums = [1, 1, 2],
        /// Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
        /// It doesn't matter what you leave beyond the new length.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            int Index = 0;
            for (int Pick = 1; Pick < nums.Length; Pick++)
            {
                if (nums[Index] != nums[Pick])
                {
                    Index++;
                    nums[Index] = nums[Pick];
                }
            }
            return Index + 1;
        }
        #endregion

        #region 27. Remove Element
        /// <summary>
        /// Given an array and a value, remove all instances of that value in place and return the new length.
        /// Do not allocate extra space for another array, you must do this in place with constant memory.
        /// The order of elements can be changed. It doesn't matter what you leave beyond the new length.
        /// Example:
        /// Given input array nums = [3, 2, 2, 3], val = 3
        /// Your function should return length = 2, with the first two elements of nums being 2.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int Index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[Index] = nums[i];
                    Index++;
                }
            }
            return Index;
        }
        #endregion

        #region 28. Implement
        /// <summary>
        /// Implement strStr().
        /// Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        /// Subscribe to see which companies asked this question
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            int Result = -1;
            if (needle == "") return 0;
            if (needle.Length > haystack.Length) return -1;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle) return i;
            }
            return Result;
        }
        #endregion

        #region 36. Valid Sudoku
        /// <summary>
        /// Determine if a Sudoku is valid, according to: Sudoku Puzzles - The Rules.
        /// The Sudoku board could be partially filled, where empty cells are filled with the character '.'.
        /// A partially filled sudoku which is valid.
        /// Note:
        /// A valid Sudoku board(partially filled) is not necessarily solvable.Only the filled cells need to be validated.
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public bool IsValidSudoku(char[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.')
                    {
                        for (int ci = i + 1; ci < 9; ci++)
                        {
                            if (board[i, j] == board[ci, j]) return false;
                        }
                        for (int cj = j + 1; cj < 9; cj++)
                        {
                            if (board[i, j] == board[i, cj]) return false;
                        }
                        int Zoomi = i / 3;
                        int Zoomj = j / 3;

                        for (int zi = Zoomi * 3; zi < Zoomi * 3 + 3; zi++)
                        {
                            for (int zj = Zoomj * 3; zj < Zoomj * 3 + 3; zj++)
                            {
                                if (i != zi && j != zj)
                                {
                                    if (board[i, j] == board[zi, zj]) return false;
                                }
                            }
                        }

                    }
                }
            }
            return true;
        }

        #endregion

        #region 38. Count and Say
        /// <summary>
        /// The count-and-say sequence is the sequence of integers beginning as follows:
        /// 1, 11, 21, 1211, 111221, 312211,...
        /// 1 is read off as "one 1" or 11.
        /// 11 is read off as "two 1s" or 21.
        /// 21 is read off as "one 2, then one 1" or 1211.
        /// Given an integer n, generate the nth sequence.
        /// Note: The sequence of integers will be represented as a string.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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
        #endregion

        #region 58. Length of Last Word
        /// <summary>
        /// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
        /// If the last word does not exist, return 0.
        /// Note: A word is defined as a character sequence consists of non-space characters only.
        /// For example,
        /// Given s = "Hello World",
        /// return 5.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLastWord(string s)
        {
            string[] strarray = s.Trim().Split(' ');
            return strarray[strarray.Length - 1].Length;
        }
        #endregion

        #region 66. Plus One
        /// <summary>
        /// Given a non-negative number represented as an array of digits, plus one to the number.
        /// The digits are stored such that the most significant digit is at the head of the list
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            List<int> temp = new List<int>();
            digits[digits.Length - 1]++;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 10)
                {
                    temp.Add(digits[i]);
                }
                else
                {
                    temp.Add(0);

                    if (i == 0) temp.Add(1);
                    else digits[i - 1]++;
                }
            }
            temp.Reverse();
            return temp.ToArray<int>();
        }
        #endregion

        #region 67. Add Binary
        /// <summary>
        /// Given two binary strings, return their sum (also a binary string).
        /// For example,
        /// a = "11"
        /// b = "1"
        /// Return "100".
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary(string a, string b)
        {
            if (a.Length < b.Length)
            {
                string T = a;
                a = b;
                b = T;
            }
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                int aLocation = a.Length - 1 - i;
                int bLocation = b.Length - 1 - i;
                if (b.Length > i)
                {
                    sum = Convert.ToInt16(Convert.ToString(a[aLocation])) + Convert.ToInt16(Convert.ToString(b[bLocation]));
                }

                if (sum % 2 == 0)
                {
                    a = a.Substring(0, aLocation) + "0" + a.Substring(aLocation + 1, a.Length - (aLocation + 1));
                }
                else
                {
                    a = a.Substring(0, aLocation) + "1" + a.Substring(aLocation + 1, a.Length - (aLocation + 1));
                }

                if (sum / 2 == 1)
                {
                    if (a.Length == aLocation - 1)
                    {
                        a = "1" + a;
                    }
                    else
                    {

                        a = a.Substring(0, aLocation - 1) +
                            Convert.ToString(Convert.ToInt16(Convert.ToString(a[aLocation - 1])) + 1) +
                            a.Substring(aLocation, a.Length - (aLocation + 1));
                    }
                }
            }
            return a;
        }
        #endregion

        #region 70. Climbing Stairs
        /// <summary>
        /// You are climbing a stair case. It takes n steps to reach to the top.
        /// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            int LastisOneCount = 0;
            int LastisTwoCount = 0;
            if (n != 0)
            {
                LastisOneCount = 1;
                for (int i = 1; i < n; i++)
                {
                    int OldLastisOneCount = LastisOneCount;
                    int OldLastisTwoCount = LastisTwoCount;
                    LastisOneCount = OldLastisOneCount + OldLastisTwoCount;
                    LastisTwoCount = OldLastisOneCount;

                }
            }


            return LastisOneCount + LastisTwoCount;
        }
        #endregion

        #region 83. Remove Duplicates from Sorted List
        /// <summary>
        /// Given a sorted linked list, delete all duplicates such that each element appear only once.
        /// For example,
        /// Given 1->1->2, return 1->2.
        /// Given 1->1->2->3->3, return 1->2->3.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) { return null; }
            if (head.next == null) { return head; }
            head.next = DeleteDuplicates(head.next);
            if (head.val == head.next.val)
            {
                head = head.next;
            }


            return head;
        }
        #endregion


        #region 88. Merge Sorted Array
        /// <summary>
        /// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
        /// Note:
        /// You may assume that nums1 has enough space (size that is greater or equal to m + n) 
        /// to hold additional elements from nums2. The number of elements initialized in nums1 and nums2 
        /// are m and n respectively.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i >= 0 && n > 0; i--)
            {
                if (m == 0) nums1[i] = nums2[--n];
                else
                {
                    if (nums1[m - 1] < nums2[n - 1]) nums1[i] = nums2[--n];
                    else nums1[i] = nums1[--m];
                }
            }

        }
        #endregion

        #region 100. Same Tree
        /// <summary>
        /// Given two binary trees, write a function to check if they are equal or not.
        /// Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            bool issame = true;
            if (p == null || q == null)
            {
                if (p == null && q == null) return true;
                else return false;
            }
            if (p.val != q.val) return false;
            if (p.right != null || q.right != null)
            {
                if (p.right != null && q.right != null)
                {
                    if (!IsSameTree(p.right, q.right)) return false;
                }
                else return false;
            }

            if (p.left != null || q.left != null)
            {
                if (p.left != null && q.left != null)
                {
                    if (!IsSameTree(p.left, q.left)) return false;
                }
                else return false;
            }

            return issame;
        }
        public bool IsSameTree2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val == q.val) return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            else return false;
        }
        #endregion

        #region 101. Symmetric Tree
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            else
            {
                return IsSymmetric(root.left, root.right);
            }
        }
        public bool IsSymmetric(TreeNode p, TreeNode q)
        {
            bool issame = true;
            if (p == null || q == null)
            {
                if (p == null && q == null) return true;
                else return false;
            }
            if (p.val != q.val) return false;
            if (p.right != null || q.left != null)
            {
                if (p.right != null && q.left != null)
                {
                    if (!IsSymmetric(p.right, q.left)) return false;
                }
                else return false;
            }

            if (p.left != null || q.right != null)
            {
                if (p.left != null && q.right != null)
                {
                    if (!IsSymmetric(p.left, q.right)) return false;
                }
                else return false;
            }

            return issame;
        }
        public bool IsSymmetric2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val == q.val) return IsSameTree(p.left, q.right) && IsSameTree(p.right, q.left);
            else return false;
        }
        #endregion

        #region 102. Binary Tree Level Order Traversal
        /// <summary>
        /// Given a binary tree, return the level order traversal of its nodes' values. 
        /// (ie, from left to right, level by level).
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<List<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return new List<List<int>>();
            AddList(1, root);
            return dic.Select(i => i.Value).ToList();
        }

        public void AddList(int Level, TreeNode node)
        {
            if (!dic.ContainsKey(Level))
            {
                List<int> templist = new List<int>();
                templist.Add(node.val);
                dic.Add(Level, templist);
            }
            else
            {
                dic[Level].Add(node.val);
            }
            Level++;
            if (node.left != null)
            {
                AddList(Level, node.left);
            }
            if (node.right != null)
            {
                AddList(Level, node.right);
            }
        }

        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();


        #endregion

        #region 104. Maximum Depth of Binary Tree
        /// <summary>
        /// Given a binary tree, find its maximum depth.
        /// The maximum depth is the number of nodes along the longest path from the root node down to 
        /// the farthest leaf node.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            int Max = 0;
            if (root == null) return Max;

            return GetMax(Max, root);
        }
        public int GetMax(int Max, TreeNode node)
        {
            int Result = ++Max;
            int TempMax;
            if (node.left != null)
            {
                TempMax = GetMax(Max, node.left);
                if (TempMax > Result) Result = TempMax;
            }
            if (node.right != null)
            {
                TempMax = GetMax(Max, node.right);
                if (TempMax > Result) Result = TempMax;
            }
            return Result;
        }

        #endregion

        #region 107. Binary Tree Level Order Traversal II
        /// <summary>
        /// Given a binary tree, return the bottom-up level order traversal of its nodes' values. 
        /// (ie, from left to right, level by level from leaf to root).
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<List<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return new List<List<int>>();
            OrderBottom(1, root);
            return dic.OrderByDescending(i => i.Key).Select(k => k.Value).ToList();
        }

        public void OrderBottom(int Level, TreeNode node)
        {
            if (!dic.ContainsKey(Level))
            {
                List<int> templist = new List<int>();
                templist.Add(node.val);
                dic.Add(Level, templist);
            }
            else
            {
                dic[Level].Add(node.val);
            }
            Level++;
            if (node.left != null)
            {
                OrderBottom(Level, node.left);
            }
            if (node.right != null)
            {
                OrderBottom(Level, node.right);
            }
        }

        #endregion

        #region 110. Balanced Binary Tree
        /// <summary>
        /// Given a binary tree, determine if it is height-balanced.
        /// For this problem, a height-balanced binary tree is defined as a binary tree in
        /// which the depth of the two subtrees of every node never differ by more than 1.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            return (Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) <= 1) && IsBalanced(root.left) && IsBalanced(root.right);
        }
        #endregion

        #region 111. Minimum Depth of Binary Tree
        /// <summary>
        /// Given a binary tree, find its minimum depth.
        /// The minimum depth is the number of nodes along the shortest path from 
        /// the root node down to the nearest leaf node.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {

            int min = 0;

            return GetMin(min, root);
        }
        public int GetMin(int min, TreeNode node)
        {
            if (node == null) return min;
            min++;
            if (node.left == null && node.right == null)
            {
                return min;
            }
            else if (node.left != null && node.right == null)
            {
                return GetMin(min, node.left);
            }
            else if (node.left == null && node.right != null)
            {
                return GetMin(min, node.right);
            }
            else
            {
                return Math.Min(GetMin(min, node.left), GetMin(min, node.right));
            }

        }
        #endregion

        #region 112. Path Sum
        /// <summary>
        /// Given a binary tree and a sum, determine if the tree has a root-to-leaf path such 
        /// that adding up all the values along the path equals the given sum.
        /// For example:
        /// Given the below binary tree and sum = 22,
        ///              5
        ///             / \
        ///            4   8
        ///           /   / \
        ///          11  13  4
        ///         /  \      \
        ///        7    2      1
        // return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            sum -= root.val;
            if (sum == 0 && root.left == null && root.right == null)
            {
                return true;
            }
            else
            {
                return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
            }
        }
        #endregion

        #region 118. Pascal's Triangle
        /// <summary>
        /// Given numRows, generate the first numRows of Pascal's triangle.
        /// For example, given numRows = 5,
        /// Return
        /// [
        ///      [1],
        ///     [1,1],
        ///    [1,2,1],
        ///   [1,3,3,1],
        ///  [1,4,6,4,1]
        /// [1,5,10,10,5,1]
        /// ]
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public Mylist<Mylist<int>> Generate(int numRows)
        {
            Mylist<Mylist<int>> result = new Mylist<Mylist<int>>();
            Mylist<int> mylist = new Mylist<int>();
            if (numRows > 0)
            {
                mylist.Add(0, 1);
                result.Add(0, mylist);
                for (int i = 1; i < numRows; i++)
                {
                    result.Add(i, GetNextLevel(result.GetbyKey(i - 1)));
                }
            }

            return result;
        }

        public Mylist<int> GetNextLevel(Mylist<int> olddic)
        {
            Mylist<int> newlist = new Mylist<int>();
            newlist.Add(0, 1);
            for (int i = 0; i < olddic.Count() - 1; i++)
            {
                newlist.Add(i + 1, olddic[i] + olddic[i + 1]);
            }
            newlist.Add(olddic.Count(), 1);
            return newlist;
        }

        public class Mylist<T> : List<T>
        {
            Dictionary<int, T> map = new Dictionary<int, T>();
            public void Add(int i, T t)
            {
                map.Add(i, t);
                this.Add(t);
            }
            public T GetbyKey(int key)
            {
                return map[key];
            }
        }
        #endregion

        #region 119. Pascal's Triangle II
        /// <summary>
        /// Given an index k, return the kth row of the Pascal's triangle.
        /// For example, given k = 3,
        /// Return [1,3,3,1].
        /// Note:
        /// Could you optimize your algorithm to use only O(k) extra space?
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public List<int> GetRow(int rowIndex)
        {
            List<int> list = new List<int>();
            list.Add(1);
            for (int i = 1; i <= rowIndex; i++)
            {
                int startj;
                int startk;
                if (i % 2 == 0)//奇
                {
                    list[i / 2] = list[i / 2] + list[i / 2 - 1];
                    startj = i / 2 - 1;
                    startk = i / 2 + 1;
                }
                else
                {
                    startj = i / 2;
                    startk = i / 2 + 1;
                }
                for (int j = startj, k = startk; j > 0 && k < i; j--, k++)
                {
                    list[j] = list[j] + list[j - 1];
                    list[k] = list[j];
                }


                list.Add(1);
            }
            return list;
        }
        #endregion

        #region 121. Best Time to Buy and Sell Stock
        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        /// If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), 
        /// design an algorithm to find the maximum profit.
        /// 
        /// Example 1:
        /// Input: [7, 1, 5, 3, 6, 4]
        /// Output: 5
        /// max. difference = 6-1 = 5 (not 7-1 = 6, as selling price needs to be larger than buying price)
        /// 
        /// Example 2:
        /// Input: [7, 6, 4, 3, 1]
        /// Output: 0
        /// In this case, no transaction is done, i.e. max profit = 0.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int LowestIndex = 0;
            int BestPrice = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[LowestIndex]) LowestIndex = i;
                else BestPrice = Math.Max(BestPrice, prices[i] - prices[LowestIndex]);
            }

            return BestPrice;
        }
        #endregion

        #region 125. Valid Palindrome
        /// <summary>
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
        /// <param name="s"></param>
        /// <returns></returns>
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


        #endregion

        #region 136. Single Number
        /// <summary>
        /// Given an array of integers, every element appears twice except for one. Find that single one.
        /// 
        /// Note:
        /// Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int result = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }
        #endregion

        #region 141. Linked List Cycle
        /// <summary>
        /// Given a linked list, determine if it has a cycle in it.
        /// 
        /// Follow up:
        /// Can you solve it without using extra space?
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            ListNode Fast = head;
            ListNode Slow = head;
            while (true)
            {
                try
                {
                    if (Fast.next.next != null && Slow.next != null)
                    {
                        Fast = Fast.next.next;
                        Slow = Slow.next;
                        if (Fast.GetHashCode() == Slow.GetHashCode())
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }

            }
        }

        #endregion

        #region 155. Min Stack

        #endregion

        #region 160. Intersection of Two Linked Lists
        /// <summary>
        /// Write a program to find the node at which the intersection of two singly linked lists begins.
        /// 
        /// For example, the following two linked lists:
        /// A:          a1 → a2
        ///                    ↘
        ///                      c1 → c2 → c3
        ///                    ↗            
        /// B:     b1 → b2 → b3
        /// begin to intersect at node c1.
        /// 
        /// Notes:
        /// If the two linked lists have no intersection at all, return null.
        /// The linked lists must retain their original structure after the function returns.
        /// You may assume there are no cycles anywhere in the entire linked structure.
        /// Your code should preferably run in O(n) time and use only O(1) memory.
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            return null;
        }
        #endregion





        #region 263. UglyNumber
        /// <summary>
        /// 263. UglyNumber
        /// https://leetcode.com/problems/ugly-number/
        /// Write a program to check whether a given number is an ugly number.
        ///Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. For example, 6, 8 are ugly
        /// while 14 is not ugly since it includes another prime factor 7.
        ///Note that 1 is typically treated as an ugly number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsUgly(int num)
        {

            if (num == 0) return false;
            num = Check(num, 2);
            num = Check(num, 3);
            num = Check(num, 5);
            if (num == 1) return true;
            else return false;
        }

        public int Check(int cNum, int fNum)
        {
            if (cNum % fNum != 0)
            {
                return cNum;
            }
            else
            {
                cNum = cNum / fNum;
                cNum = Check(cNum, fNum);
                return cNum;
            }

        }
        #endregion

        #region 264. UglyNumber2
        /// <summary>
        /// 264. UglyNumber2
        /// https://leetcode.com/problems/ugly-number-ii/
        /// Write a program to find the n-th ugly number.
        ///Ugly numbers are positive numbers whose prime factors only include 2, 3, 5.
        /// For example, 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 is the sequence of the first 10 ugly numbers.
        ///Note that 1 is typically treated as an ugly number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NthUglyNumber(int n)
        {
            int[] Ugly = new int[n];

            int factor2 = 2;
            int factor3 = 3;
            int factor5 = 5;
            int Index2 = 0;
            int Index3 = 0;
            int Index5 = 0;

            Ugly[0] = 1;
            for (int i = 1; i < n; i++)
            {
                Ugly[i] = Min(Min(factor2, factor3), factor5);

                if (Ugly[i] == factor2) factor2 = 2 * Ugly[++Index2];
                if (Ugly[i] == factor3) factor3 = 3 * Ugly[++Index3];
                if (Ugly[i] == factor5) factor5 = 5 * Ugly[++Index5];
            }
            return Ugly[n - 1];
        }

        public int Min(int num1, int num2)
        {
            if (num1 > num2) return num2;
            else return num1;
        }

        #endregion

    }

    #region ListNode
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    #endregion

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
