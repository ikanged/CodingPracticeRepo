using System;
namespace CodingPractice.Helpers
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public TreeNode<T> Root
        {
            get; set;
        }

        /// <summary>
        /// Inserts node in to BST.
        /// Values that are less than root will be placed on the Left Side 
        /// Values that are greater than root will be placed on the Right Side
        /// </summary>
        /// <param name="value"></param>
        /// <param name="node"></param>
        public void InsertNodeToBST(T value, TreeNode<T> node)
        {
            var bstNewNode = new TreeNode<T> { Value = value };

            //Pass in node is less so go to left 
            if (bstNewNode < node)
            {
                if (node.left == null)
                {
                    node.left = bstNewNode;
                }
                else
                {
                    InsertNodeToBST(value, node.left);
                }
            }

            //Passed in node is greater so go to right
            if (bstNewNode >= node)
            {
                if (node.right == null)
                {
                    node.right = bstNewNode;
                }
                else
                {
                    InsertNodeToBST(value, node.right);
                }
            }
        }

        #region Traversals

        //Follows Node Left Right
        public string PreOrderTraversal(TreeNode<T> node, string values)
        {
            values += node.Value + " ";

            if (node.left != null)
            {
                PreOrderTraversal(node.left, values);
            }

            if (node.right != null)
            {
                PreOrderTraversal(node.right, values);
            }

            return values;
        }

        //Follows Left Node Right
        public string InOrderTraversal(TreeNode<T> node, string value)
        {
            if (node.left != null)
            {
                InOrderTraversal(node.left, value);
            }

            value += node.Value + " ";

            if (node.right != null)
            {
                InOrderTraversal(node.right, value);
            }

            return value;
        }

        //Follows Left Right Node
        public string PostOrderTraversal(TreeNode<T> node, string value)
        {
            if (node.left != null)
            {
                PostOrderTraversal(node.left, value);
            }

            if (node.right != null)
            {
                PostOrderTraversal(node.right, value);
            }

            value += node.Value + " ";

            return value;
        }

        #endregion

        public bool checkTree(TreeNode<T> root, TreeNode<T> minValue, TreeNode<T> maxValue)
        {
            //Initialize to True because Nodes can have 1 child and those are valid 
            bool leftTree = true;
            bool rightTree = true;

            //Leaf node check
            if (root.left == null && root.right == null)
            {
                return true;
            }

            //Check for left node
            if (root.left != null)
            {
                //Check for left node
                //Condition: Left node should be <= Current Node AND minimum value(root) should be < Left Node
                // This check is mainly for the Right Node of Root Node. Right Node values should be >  Root Node
                if (root.left <= root && (minValue == null || minValue < root.left))
                {
                    leftTree = checkTree(root.left, minValue, root);
                }
                else
                {
                    return false;
                }

            }
            if (root.right != null)
            {
                //Check for right node
                //Condition: Right node should be > Current Node AND max value (root) should be > Right Node
                //  This check is mainly for the Left Node of Root Node. Left Node values should be < Root Node
                if (root.right > root && (maxValue == null || maxValue > root.right))
                {
                    rightTree = checkTree(root.right, root, maxValue);
                }
                else
                {
                    return false;
                }
            }

            return leftTree && rightTree;
        }

        #region Binary Search Tree Properties

        //Return Max number of nodes per level

        //Return Max number of nodes for given height of tree

        //Return Min height for given number of nodes



        #endregion
    }
}
