using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 141. Linked List Cycle
    /// Given a linked list, determine if it has a cycle in it.
    /// 
    /// Follow up:
    /// Can you solve it without using extra space?
    /// </summary>
    public class Problem_141
    {
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
    }
}
