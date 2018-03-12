using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Leetcode
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //TB01.Text = "ff,fffe,fs";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            tbRunTime.Text = "--";
            DateTime StartTime = DateTime.Now;
            DateTime EndTime;
            #region 1. TwoSum
            //int[] temp = TwoSum(new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384,
            //778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23,
            //677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314,
            //422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751,
            //28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858,
            //538, 427, 583, 368, 375, 173, 809, 896, 370, 789 }, 542);
            //tbOutput01.Text = temp[0] + "," + temp[1];
            #endregion
                //CodeArea target = new CodeArea();
                //int[] num = new int[] { 2, 7, 11, 15 };
                //int[] expected = new int[] { 0, 1 };
                //int[] output = target.TwoSum(num, 9);
            
            #region 2. Add Two Numbers
            //// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            //// Output: 7 -> 0 -> 8
            //// [2,4,3]
            //// [5,6,4]
            //ListNode l1 = new ListNode(2);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);
            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);
            //ListNode objListNode = AddTwoNumbers(l1, l2);

            //tbOutput01.Text = objListNode.val + " " + objListNode.next.val + " " + objListNode.next.next;
            #endregion

            #region 3. Longest Substring Without Repeating Characters
            //tbOutput01.Text = LengthOfLongestSubstring(tbInput01.Text).ToString();
            #endregion

            #region 4. Median of Two Sorted Arrays
            //int[] intA;
            //int[] intB;
            //if (tbInput01.Text == "") tbInput01.Text = "1,2";
            //if (tbInput02.Text == "") tbInput02.Text = "3,4,5";
            //intA = Array.ConvertAll(tbInput01.Text.Split(','), int.Parse);
            //intB = Array.ConvertAll(tbInput02.Text.Split(','), int.Parse);

            //tbOutput01.Text = Convert.ToString(FindMedianSortedArrays(intA, intB));
            #endregion

            #region 5. Longest Palindromic Substring
            //tbOutput01.Text = LongestPalindrome(tbInput01.Text).ToString();
            #endregion

            #region 7. Reverse Integer
            //tbOutput01.Text = Reverse(Convert.ToInt32(tbInput01.Text)).ToString();
            #endregion

            #region 8. String to Integer (atoi)
            //tbOutput01.Text = MyAtoi(tbInput01.Text).ToString();
            #endregion

            #region 10. Regular Expression Matching

            //if (tbInput01.Text == "") tbInput01.Text = "aaa";
            //if (tbInput02.Text == "") tbInput02.Text = "";

            //tbOutput01.Text = Convert.ToString(IsMatch(tbInput01.Text,tbInput02.Text));
            #endregion

            #region 14. Longest Common Prefix
            //string[] str = new string[] { "aa", "aa" };
            //string[] str = tbInput01.Text.Split(',');

            //tbOutput01.Text = LongestCommonPrefix(str).ToString();

            #endregion

            #region 15. 3Sum
            //if (tbInput01.Text == "") tbInput01.Text = "-1,0,1";
            //if (tbInput01.Text == "") tbInput01.Text = "-3,-2,-1,0,1,2,3";
            //if (tbInput01.Text == "") tbInput01.Text = "-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0";
            //if (tbInput01.Text == "") tbInput01.Text = "-3,-4,-2,0,2,2,-2,1,-1,2,3,-1,-5,-4,-5,1";
            //if (tbInput01.Text == "") tbInput01.Text = "-1,0,1,2,-1,-4";
            //int[] ThreeSumNum = tbInput01.Text.Split(',').Select(n => Convert.ToInt32(n)).ToArray(); 
            //ThreeSum(ThreeSumNum);
            #endregion

            #region 16. 3Sum Closest
            //if (tbInput01.Text == "") tbInput01.Text = "-1,0,1";
            //if (tbInput01.Text == "") tbInput01.Text = "-3,-2,-1,0,1,2,3";
            //if (tbInput01.Text == "") tbInput01.Text = "-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0";
            //if (tbInput01.Text == "") tbInput01.Text = "-3,-4,-2,0,2,2,-2,1,-1,2,3,-1,-5,-4,-5,1";
            //if (tbInput01.Text == "") tbInput01.Text = "-1,0,1,2,-1,-4";
            if (tbInput01.Text == "") tbInput01.Text = "0,5,-1,-2,4,-1,0,-3,4,-5";
            if (tbInput02.Text == "") tbInput02.Text = "1";
            int[] ThreeSumNum = tbInput01.Text.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            tbOutput01.Text = ThreeSumClosest(ThreeSumNum, Convert.ToInt32(tbInput02.Text)).ToString();
            #endregion

            #region 19. Remove Nth Node From End of List
            //ListNode LN1 = new ListNode(2);
            //ListNode LN2 = new ListNode(1);
            //LN2.next = LN1;
            //RemoveNthFromEnd(LN2, 1);
            #endregion

            #region 20. IsValid
            //tbOutput01.Text = IsValid(tbInput01.Text).ToString();
            #endregion

            #region 24. Swap Nodes in Pairs
            //ListNode l1 = new ListNode(1);
            //ListNode l2 = new ListNode(2);
            //ListNode l3 = new ListNode(3);
            //ListNode l4 = new ListNode(4);
            //ListNode l5 = new ListNode(5);
            //l1.next = l2;
            //l2.next = l3;
            //l3.next = l4;
            //l4.next = l5;

            // SwapPairs(l1);

            #endregion

            #region 26. Remove Duplicates from Sorted Array
            //if (tbInput01.Text == "") tbInput01.Text = "1,1,1,1";
            //RemoveDuplicates(tbInput01.Text.Split(',').Select(int.Parse).ToArray());
            #endregion

            #region 38. Count and Say
            //if (tbInput01.Text == "") tbInput01.Text = "1";
            //tbOutput01.Text = CountAndSay(Convert.ToInt32(tbInput01.Text));
            #endregion

            #region 67. Add Binary
            //if (tbInput01.Text == "") tbInput01.Text = "1";
            //string[] AddBinaryTemp = tbInput01.Text.Split(',');
            //tbOutput01.Text = AddBinary(AddBinaryTemp[0], AddBinaryTemp[1]);
            #endregion

            #region 70. Climbing Stairs
            //if (tbInput01.Text == "") tbInput01.Text = "1";
            //tbOutput01.Text = Convert.ToString(ClimbStairs(Convert.ToInt32(tbInput01.Text)));
            #endregion

            #region 88. Merge Sorted Array

            //if (tbInput01.Text == "") tbInput01.Text = "1";
            //tbOutput01.Text = Convert.ToString(ClimbStairs(Convert.ToInt32(tbInput01.Text)));
            //int[] ns1=new int[]{1,3,5,7,9};
            //int[] ns2=new int[]{2,4};

            //Merge(ns1, 2, ns2, 2);
            #endregion

            #region 100. Same Tree
            
            #endregion

            #region 102. Binary Tree Level Order Traversal

            #endregion

            #region 118. Pascal's Triangle
            //if (tbInput01.Text == "") tbInput01.Text = "3";
            //Generate(Convert.ToInt32(tbInput01.Text));
            #endregion

            #region 119. Pascal's Triangle IIion
            //if (tbInput01.Text == "") tbInput01.Text = "13";
            //GetRow(Convert.ToInt32(tbInput01.Text));
            #endregion

            #region 125. Valid Palindrome
            //if (tbInput01.Text == "") tbInput01.Text = "A man, a plan, a canal: Panama";
            //tbOutput01.Text = Convert.ToString(IsPalindrome(tbInput01.Text));
            #endregion

            #region 141. Linked List Cycle
            //ListNode A = new ListNode(1);
            //ListNode B = new ListNode(2);
            //ListNode C = new ListNode(3);
            //ListNode D = new ListNode(4);
            //ListNode E = new ListNode(5);
            //ListNode F = new ListNode(6);
            //ListNode G = new ListNode(7);

            ////A.next = A;
            ////B.next = C;
            ////C.next = D;
            ////D.next = E;
            ////E.next = F;
            ////F.next = G;
            ////G.next = D;
            //tbOutput01.Text = Convert.ToString(HasCycle(A));

            #endregion


            EndTime = DateTime.Now;
            tbRunTime.Text = (EndTime - StartTime).ToString();
        }


    }



}
