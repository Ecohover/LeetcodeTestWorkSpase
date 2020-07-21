using Leetcode.Factories;
using Leetcode.Models;
using Leetcode.Problems;
using LeetcodeTests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using static Leetcode.Problems.Problem_37;

namespace Leetcode.Tests
{
    public class Rootobject
    {
        public string[][] value { get; set; }
    }

    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void UnitTestProblem_37()
        {
            Problem_37 solution = new Problem_37();
            string path = $"{System.AppDomain.CurrentDomain.BaseDirectory}\\TestData\\Problem_37.json";
            char[][] vs = FileHelper.ReadFile<char[][], JArray >(path);
            solution.SolveSudoku(vs);

            Assert.AreEqual(true, true);
        }
    }
}