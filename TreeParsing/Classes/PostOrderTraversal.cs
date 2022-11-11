using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;

namespace TreeParsing.Classes
{
    public class PostOrderTraversal : TreeTraversal
    {
        private List<int> _traversal;
        public List<int> Traversal { get { return _traversal; } set { _traversal = value; } }

        public List<int> Run(TreeNode root)
        {
            Traversal = new List<int>();

            Traverse(root);

            return Traversal;
        }
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
