using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 21. Merge Two Sorted Lists
    /// Merge two sorted linked lists and return it as a new list.
    /// The new list should be made by splicing together the nodes of the first two lists.
    /// </summary>
    public class Problem_21
    {
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
    }
}
