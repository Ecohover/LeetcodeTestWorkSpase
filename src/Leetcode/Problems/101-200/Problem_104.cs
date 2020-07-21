using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 104. Maximum Depth of Binary Tree
    /// Given a binary tree, find its maximum depth.
    /// The maximum depth is the number of nodes along the longest path from the root node down to 
    /// the farthest leaf node.
    /// </summary>
    public class Problem_104
    {
        public static int MaxDepth(TreeNode root)
        {
            int Max = 0;
            if (root == null) return Max;

            return GetMax(Max, root);
        }
        public static int GetMax(int Max, TreeNode node)
        {
            int Result = ++Max;
            int TempMax;
            if (node.left != null)
            {
                TempMax = GetMax(Max, node.left);
                if (TempMax > Result) Result = TempMax;
            }
            if (node.right != null)
            {
                TempMax = GetMax(Max, node.right);
                if (TempMax > Result) Result = TempMax;
            }
            return Result;
        }
    }
}
