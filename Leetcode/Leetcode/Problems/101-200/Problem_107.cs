using Leetcode.Models;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problems
{
    /// <summary>
    /// 107. Binary Tree Level Order Traversal II
    /// Given a binary tree, return the bottom-up level order traversal of its nodes' values. 
    /// (ie, from left to right, level by level from leaf to root).
    /// </summary>
    public class Problem_107
    {
        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
        public List<List<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return new List<List<int>>();
            OrderBottom(1, root);
            return dic.OrderByDescending(i => i.Key).Select(k => k.Value).ToList();
        }

        public void OrderBottom(int Level, TreeNode node)
        {
            if (!dic.ContainsKey(Level))
            {
                List<int> templist = new List<int>();
                templist.Add(node.val);
                dic.Add(Level, templist);
            }
            else
            {
                dic[Level].Add(node.val);
            }
            Level++;
            if (node.left != null)
            {
                OrderBottom(Level, node.left);
            }
            if (node.right != null)
            {
                OrderBottom(Level, node.right);
            }
        }
    }
}
