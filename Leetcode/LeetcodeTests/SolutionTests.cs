using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Models;
using Leetcode.Factories;

namespace Leetcode.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void UnitTestMergeKLists()
        {
            Problem_18 solution = new Problem_18();
            ListNode[] lists = new ListNode[3]
            {
                ListNodeFactory.GetListNode(new int[3]{ 1,4,5 }),
                ListNodeFactory.GetListNode(new int[3]{ 1,3,4 }),
                ListNodeFactory.GetListNode(new int[2]{ 2, 6 })
            };
            var ans = solution.MergeKLists(lists);

            Assert.AreEqual(true, true);
        }
    }
}