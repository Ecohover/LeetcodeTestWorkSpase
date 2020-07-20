using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 24. Swap Nodes in Pairs
    /// Given a linked list, swap every two adjacent nodes and return its head.
    /// For example,
    /// Given 1->2->3->4, you should return the list as 2->1->4->3.
    /// Your algorithm should use only constant space.You may not modify the values in the list,
    /// only nodes itself can be changed.
    /// </summary>
    public class Problem_24
    {
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
    }
}
