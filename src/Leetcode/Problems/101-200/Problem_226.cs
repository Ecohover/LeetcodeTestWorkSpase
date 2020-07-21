using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 226. Invert a binary tree
    /// Invert a binary tree.
    ///  Example:
    ///  Input:
    ///       4
    ///     /   \
    ///    2     7
    ///   / \   / \
    ///  1   3 6   9
    ///  Output:
    ///       4
    ///     /   \
    ///    7     2
    ///   / \   / \
    ///  9   6 3   1
    /// </summary>
    public class Problem_226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            if (root.right != null || root.left != null)
            {
                TreeNode temp = root.left;
                root.left = InvertTree(root.right);
                root.right = InvertTree(temp);
            }
            return root;

        }
    }
}
