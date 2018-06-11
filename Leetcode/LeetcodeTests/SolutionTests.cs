using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    [TestClass()]
    public class SolutionTests
    {

        [TestMethod()]
        public void TwoSumTest()
        {
            Solution solution = new Solution();
            int[] num = new int[] { 2, 7, 11, 15 };
            int[] expected = new int[] { 0, 1 };
            int[] output = solution.TwoSum(num, 9);
            CollectionAssert.AreEqual(expected, output);
        }

        [TestMethod()]
        public void SearchInsertTest()
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 5;
            int Result = solution.SearchInsert(nums, target);
            int Expected = 2;
            Assert.AreEqual(Result, Expected);
        }

        [TestMethod()]
        public void SearchInsertTest2()
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 7;
            int Result = solution.SearchInsert(nums, target);
            int Expected = 4;
            Assert.AreEqual(Result, Expected);
        }
    }
}