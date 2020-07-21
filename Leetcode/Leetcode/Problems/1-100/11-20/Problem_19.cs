using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 19. Remove Nth Node From End of List
    /// Given a linked list, remove the nth node from the end of list and return its head.
    /// For example,
    /// Given linked list: 1->2->3->4->5, and n = 2.
    /// After removing the second node from the end, the linked list becomes 1->2->3->5.
    /// </summary>
    public class Problem_19
    {
        public int NodeLocation = 0;
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
    }
}
