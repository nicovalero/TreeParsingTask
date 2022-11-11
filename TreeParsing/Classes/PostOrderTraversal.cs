using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;

namespace TreeParsing.Classes
{
    /// <summary>
    /// Class <c>PostOrderTraversal</c> defines an object that traverses through a tree
    /// using the Post-Order traversal technique.
    /// </summary>
    public class PostOrderTraversal : TreeTraversal
    {
        private List<int> _traversal;
        public List<int> Traversal { get { return _traversal; } set { _traversal = value; } }

        /// <summary>
        /// Method <c>Run</c> runs the traversal and stores the value in a List of integers.
        /// </summary>
        /// <param name="root"></param>
        /// <returns>A list of integers with all the values from the tree</returns>
        public List<int> Run(TreeNode root)
        {
            Traversal = new List<int>();

            Traverse(root);

            return Traversal;
        }

        /// <summary>
        /// Method <c>Traverse</c> visits all the nodes in a tree using a post-order technique
        /// and updates the Traversal list.
        /// </summary>
        /// <param name="node"></param>
        public void Traverse(TreeNode node)
        {
            if (node != null)
            {
                List<TreeNode> children = node.GetChildren();

                foreach (TreeNode child in children)
                {
                    if (child != null)
                        Traverse(child);
                }

                Traversal.Add(node.Value);
            }
        }
    }
}
