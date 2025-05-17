using System;
using CodingPractice.Helpers;
namespace CodingPractice.Problems.GeeksForGeeks
{
    public class HeightOfBinaryTree : AbsProblem, IProblem
    {
        /*
         *  Given the Root of the Tree, determine the height of the tree
         * Input:
                 1
                /  \
               2    3
            Output: 2

            Input:
                  2
                   \
                    1
                   /
                 3
            Output: 3   
        */
        public HeightOfBinaryTree() : base("Height Of Binary Tree")
        {

        }

        public override void Begin()
        {
            TreeNode<int> root = new TreeNode<int>();

            root.Value = 1;
            root.InsertNode(root, 2, true);
            root.InsertNode(root, 3, false);
            root.InsertNode(root.left, 4, false);
            root.InsertNode(root.left, 5, true);
            root.InsertNode(root.right.left, 6, true);
            root.InsertNode(root.right.left, 7, true);
            root.InsertNode(root.right.left, 8, true);

            int height = getHeight(root);

            DisplayMessage($"Height Of Tree: {height}");
        }

        private int getHeight(TreeNode<int> node)
        {

            if (node == null)
            {
                return -1;
            }

            var currLeftLevel = getHeight(node.left);
            var currRightLevel = getHeight(node.right);

            return  currLeftLevel>= currRightLevel ? currLeftLevel + 1: currRightLevel + 1;
        }
    }
}
