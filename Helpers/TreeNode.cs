using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Helpers
{
    public class TreeNode<T> where T : IComparable
    {
        public TreeNode<T> left { get; set; }
        public TreeNode<T> right { get; set; }
        public T Value { get; set; }

        #region Operator Overloads


        //Overriding Equals function
        //This function will be used in other framework (array.Sort)
        //to compare the values of each node
        public override bool Equals(object obj)
        {
            if (obj is TreeNode<T> other)
            {
                if (ReferenceEquals(Value, other.Value))
                {
                    return true;
                }
            }

            return false;
        }

        //GetHashCode is used in mapping values in Dictionary or HashSet 
        public override int GetHashCode()
        {
            return Value == null ? 0 : Value.GetHashCode();
        }

        /* - Operator overloading - 
         * Overriding comparison logic for TreeNode
         * This will replace the default logic whenever any 
         * comparsion logic is implemented. 
         * 
         * This needs to be done whenever Equals is overwritten
         */
        public static bool operator ==(TreeNode<T> left, TreeNode<T> right) => ReferenceEquals(left, right) || (left?.Equals(right) ?? false);
        public static bool operator !=(TreeNode<T> left, TreeNode<T> right) => !(left == right);

        //Less than or Greater than comparison will also be overriden
        //CompareTo will return
        // - Less than 0 for values that precedes in sort order
        // - Greater than 0 for values that follows in sort order
        // - 0 for values that are in the same position in sort order
        public static bool operator <(TreeNode<T> left, TreeNode<T> right)
        {
            return left.Value.CompareTo(right.Value) < 0;
        }
        public static bool operator >(TreeNode<T> left, TreeNode<T> right)
        {
            return left.Value.CompareTo(right.Value) > 0;
        }

        public static bool operator <=(TreeNode<T> left, TreeNode<T> right)
        {
            return left.Value.CompareTo(right.Value) <= 0;
        }
        public static bool operator >=(TreeNode<T> left, TreeNode<T> right)
        {
            return left.Value.CompareTo(right.Value) >= 0;
        }

        #endregion

        #region Insert Node

        /// <summary>
        /// Inserts node in to left or right
        /// 1 for left, 2 for right
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <param name="direction"></param>
        public void InsertNode(TreeNode<T> node, T value, bool direction)
        {
            //Insert left
            if (direction)
            {
                if(node == null)
				{
                    node = new TreeNode<T>();
                    node.Value = value;
				}
                else
				{
                    node.left = new TreeNode<T>();
                    node.left.Value = value;
				}
            }
            //Insert right
            else
            {
                if (node == null)
				{
                    node = new TreeNode<T>();
                    node.Value = value;
                }
                else
				{
                    node.right = new TreeNode<T>();
                    node.right.Value = value;
				}
            }
        }

        #endregion
    }
}
