using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 83. Remove Duplicates from Sorted List
    /// Given a sorted linked list, delete all duplicates such that each element appear only once.
    /// For example,
    /// Given 1->1->2, return 1->2.
    /// Given 1->1->2->3->3, return 1->2->3.
    /// </summary>
    public class Problem_83
    {
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
    }
}
