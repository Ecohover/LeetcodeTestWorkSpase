using Leetcode.Models;
using System;

namespace Leetcode.Problems
{
    /// <summary>
    /// 110. Balanced Binary Tree
    /// Given a binary tree, determine if it is height-balanced.
    /// For this problem, a height-balanced binary tree is defined as a binary tree in
    /// which the depth of the two subtrees of every node never differ by more than 1.
    /// </summary>
    public class Problem_110
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            return (Math.Abs(Problem_104.MaxDepth(root.left) - Problem_104.MaxDepth(root.right)) <= 1) && IsBalanced(root.left) && IsBalanced(root.right);
        }
    }
}
