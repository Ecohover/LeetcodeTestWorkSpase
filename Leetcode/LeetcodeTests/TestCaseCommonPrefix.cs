using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Models;
using Leetcode.Factories;
using Leetcode.Problems;

namespace Leetcode.Tests
{
    [TestClass()]
    public class TestCaseCommonPrefix
    {
        [TestMethod()]
        public void UnitTestCommonPrefix()
        {
            Problem_14 solution = new Problem_14();
            string[] strs = new string[]
                        {
                            "CDAABCDD",
                            "CDFF",
                            "CD586CD"
                        };
            string ans = solution.LongestCommonPrefix(strs);
            Assert.AreEqual("CD", ans);
        }
    }
}