using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;

namespace TreeParsing.Classes
{
    public class PostOrderTraversal : TreeTraversal
    {
        private List<int> _traversal;

        public List<int> Run(TreeNode root)
        {
            _traversal = new List<int>();

            Traverse(root);

            return _traversal;
        }
        public void Traverse(TreeNode node)
        {
            List<TreeNode> children = node.GetChildren();

            foreach(TreeNode child in children)
            {
                if(child != null)
                    Traverse(child);
            }

            _traversal.Add(node.Value);
        }
    }
}
