using System;

namespace ChapterFour
{
    public class BalancedTree
    {
        public int MaxDepth (TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
        public bool checkBalance(TreeNode root)
        {
            return (MaxDepth(root) - MinDepth(root) <= 1);
        }
    }
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
