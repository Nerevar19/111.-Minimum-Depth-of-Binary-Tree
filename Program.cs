﻿namespace _111._Minimum_Depth_of_Binary_Tree
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null) return MinDepth(root.right) + 1;
            if (root.right == null) return MinDepth(root.left) + 1;
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}