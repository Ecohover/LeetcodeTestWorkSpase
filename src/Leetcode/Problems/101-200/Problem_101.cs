using Leetcode.Models;

namespace Leetcode.Problems
{
    /// <summary>
    /// 101. Symmetric Tree
    /// </summary>
    public class Problem_101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            else
            {
                return IsSymmetric(root.left, root.right);
            }
        }
        public bool IsSymmetric(TreeNode p, TreeNode q)
        {
            bool issame = true;
            if (p == null || q == null)
            {
                if (p == null && q == null) return true;
                else return false;
            }
            if (p.val != q.val) return false;
            if (p.right != null || q.left != null)
            {
                if (p.right != null && q.left != null)
                {
                    if (!IsSymmetric(p.right, q.left)) return false;
                }
                else return false;
            }

            if (p.left != null || q.right != null)
            {
                if (p.left != null && q.right != null)
                {
                    if (!IsSymmetric(p.left, q.right)) return false;
                }
                else return false;
            }

            return issame;
        }
        public bool IsSymmetric2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val == q.val) return Problem_100.IsSameTree(p.left, q.right) && Problem_100.IsSameTree(p.right, q.left);
            else return false;
        }
    }
}
