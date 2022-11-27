using Leetcode.Models;
using System;
using System.Linq;

namespace Leetcode.Problems
{
    /// <summary>
    /// 23. Merge k Sorted Lists
    /// Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
    /// </summary>
    public class Problem_23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 1) return lists[0];
            lists = lists.OrderBy(list => list.val).ToArray();
            ListNode NewNode = lists[0];

            for (int i = 1; i < lists.Length; i++)
            {
                while (lists[1] != null)
                {
                    var temp = SwitchList(NewNode, lists[1]);
                    NewNode = temp.Item1;
                    lists[1] = temp.Item2;
                }
            }

            return NewNode;
        }

        public Tuple<ListNode, ListNode> SwitchList(ListNode lists0, ListNode lists1)
        {
            if (lists0.next == null)
            {
                lists0.next = lists1;
            }
            else
            {
                if (lists0.next.val > lists1.val)
                {
                    ListNode temp = lists1;
                    lists1 = lists0.next;
                    lists0.next = temp;
                }
                else
                {
                    var temp = SwitchList(lists0.next, lists1);
                    lists0.next = temp.Item1;
                    lists1 = temp.Item2;
                }
            }
            return new Tuple<ListNode, ListNode>(lists0, lists1);
        }
    }
}
