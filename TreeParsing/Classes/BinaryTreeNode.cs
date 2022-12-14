using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;

namespace TreeParsing.Classes
{
    /// <summary>
    /// Class <c>BinaryTreeNode</c> defines a Node with two possible children only, and an integer value.
    /// </summary>
    public class BinaryTreeNode : TreeNode
    {
        private const int LEFTPOSITION = 0;
        private const int RIGHTPOSITION = 1;
        private List<TreeNode> _children;
        private TreeNode Left { get { return _children[LEFTPOSITION]; } set { _children[LEFTPOSITION] = value; } }
        private TreeNode Right { get { return _children[RIGHTPOSITION]; } set { _children[RIGHTPOSITION] = value; } }

        private int _value;
        public int Value { get { return _value; } set { _value = value; } }

        public BinaryTreeNode(int value, BinaryTreeNode left = null, BinaryTreeNode right = null)
        {
            _children = new List<TreeNode>();
            _children.Add(left);
            _children.Add(right);
            _value = value;
        }

        /// <summary>
        /// Method <c>GetChildren</c>
        /// </summary>
        /// <returns>The immediate children of this node</returns>
        public List<TreeNode> GetChildren()
        {
            return _children;
        }

        ///<summary>
        ///Method <c>AddNode</c> adds the given node where possible
        ///</summary
        /// <returns>Returns false if node already exists or is not a BinaryTreeNode</returns>
        public virtual bool AddNode(TreeNode node)
        {
            if (node is BinaryTreeNode)
            {
                if (this.Value == node.Value)
                    return false;

                if (node.Value > this.Value)
                {
                    if (this.Right == null)
                    {
                        this.Right = node;
                        return true;
                    }
                    else
                        return this.Right.AddNode(node);
                }
                else
                {
                    if (this.Left == null)
                    {
                        this.Left = node;
                        return true;
                    }
                    else
                        return this.Left.AddNode(node);
                }
            }
            else
                return false;
        }
    }
}
