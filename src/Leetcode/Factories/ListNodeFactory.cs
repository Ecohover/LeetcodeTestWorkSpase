using Leetcode.Models;
using System;

namespace Leetcode.Factories
{
    public static class ListNodeFactory
    {
        public static ListNode GetListNode(int[] val)
        {
            ListNode node = new ListNode();
            node.val = val[0];
            if (val.Length > 1)
            {
                int[] nextarray = new int[val.Length - 1];
                Array.Copy(val, 1, nextarray, 0, val.Length - 1);
                node.next = GetListNode(nextarray);
            }
            return node;
        }
    }
}
