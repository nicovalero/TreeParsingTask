using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;
using TreeParsing.Classes;

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
            if (Root == null)
            {
                Root = node;
                return true;
            }
            else
                return Root.AddNode(node);
        }

        public void ProcessInput(string input)
        {
            ClearRoot();
            List<int> list = InputParser.GetIntegerList(input);

            list = ListValidator.GetValidList(list);
            if (list.Count > 0)
            {
                Root = new BinaryTreeNode(list[0]);

                for (int i = 1; i < list.Count; i++)
                    AddNode(new BinaryTreeNode(list[i]));
            }
        }

        public List<int> GetPostOrderTraversal()
        {
            List<int> result = new List<int>();

            if (_postOrderTraversal != null && Root != null)
            {
                result = _postOrderTraversal.Run(Root);
            }

            return result;
        }

        public void ClearRoot()
        {
            Root = null;
        }
    }
}
