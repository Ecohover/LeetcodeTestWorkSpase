using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 2. Add Two Numbers
    /// You are given two linked lists representing two non-negative numbers.
    /// The digits are stored in reverse order and each of their nodes contain a single digit.
    /// Add the two numbers and return it as a linked list.
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output: 7 -> 0 -> 8
    /// </summary>
    public class Problem_2
    {
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
    }
}
