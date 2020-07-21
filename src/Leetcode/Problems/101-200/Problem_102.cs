using Leetcode.Models;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problems
{
    /// <summary>
    /// 102. Binary Tree Level Order Traversal
    /// Given a binary tree, return the level order traversal of its nodes' values. 
    /// (ie, from left to right, level by level).
    /// </summary>
    public class Problem_102
    {
        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
        public List<List<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return new List<List<int>>();
            AddList(1, root);
            return dic.Select(i => i.Value).ToList();
        }

        public void AddList(int Level, TreeNode node)
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
                AddList(Level, node.left);
            }
            if (node.right != null)
            {
                AddList(Level, node.right);
            }
        }

    }
}
