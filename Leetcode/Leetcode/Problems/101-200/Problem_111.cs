using Leetcode.Models;
using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 111. Minimum Depth of Binary Tree
    /// Given a binary tree, find its minimum depth.
    /// The minimum depth is the number of nodes along the shortest path from 
    /// the root node down to the nearest leaf node.
    /// </summary>
    public class Problem_111
    {
        public int MinDepth(TreeNode root)
        {

            int min = 0;

            return GetMin(min, root);
        }
        public int GetMin(int min, TreeNode node)
        {
            if (node == null) return min;
            min++;
            if (node.left == null && node.right == null)
            {
                return min;
            }
            else if (node.left != null && node.right == null)
            {
                return GetMin(min, node.left);
            }
            else if (node.left == null && node.right != null)
            {
                return GetMin(min, node.right);
            }
            else
            {
                return Math.Min(GetMin(min, node.left), GetMin(min, node.right));
            }

        }
    }
}
