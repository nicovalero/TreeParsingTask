using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;

namespace TreeParsing.Controller
{
    public class TreeController
    {
        private TreeNode _root;
        public TreeNode Root { get { return _root; } set { _root = value; } }
        private TreeTraversal _postOrderTraversal;

        public TreeController(TreeTraversal postOrderTraversal)
        {
            _postOrderTraversal = postOrderTraversal;
        }

        public bool AddNode(TreeNode node)
        {
            return Root.AddNode(node);
        }

        public List<int> GetPostOrderTraversal()
        {
            List<int> result = new List<int>();

            if(_postOrderTraversal != null && Root != null)
            {
                result = _postOrderTraversal.Run(Root);
            }

            return result;
        }
    }
}
