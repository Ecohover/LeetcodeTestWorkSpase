using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 100. Same Tree
    /// Given two binary trees, write a function to check if they are equal or not.
    /// Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
    /// </summary>
    public class Problem_100
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            bool issame = true;
            if (p == null || q == null)
            {
                if (p == null && q == null) return true;
                else return false;
            }
            if (p.val != q.val) return false;
            if (p.right != null || q.right != null)
            {
                if (p.right != null && q.right != null)
                {
                    if (!IsSameTree(p.right, q.right)) return false;
                }
                else return false;
            }

            if (p.left != null || q.left != null)
            {
                if (p.left != null && q.left != null)
                {
                    if (!IsSameTree(p.left, q.left)) return false;
                }
                else return false;
            }

            return issame;
        }
        public bool IsSameTree2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val == q.val) return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            else return false;
        }
    }
}
