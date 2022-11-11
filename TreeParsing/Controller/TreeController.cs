using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;
using TreeParsing.Classes;

namespace TreeParsing.Controller
{
    /// <summary>
    /// Class <c>TreeController</c> defines a class to manage inputs from the user
    /// and creates/updates tree structures.
    /// </summary>
    public class TreeController
    {
        private TreeNode _root;
        public TreeNode Root { get { return _root; } set { _root = value; } }
        private TreeTraversal _postOrderTraversal;

        public TreeController(TreeTraversal postOrderTraversal)
        {
            _postOrderTraversal = postOrderTraversal;
        }

        /// <summary>
        /// Method <c>AddNode</c> adds a new node to the tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns>True if the node is successfully added. False if could not be added.</returns>
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

        /// <summary>
        /// Method <c>ProcessInput</c> obtains the raw input from the user,
        /// parses to a list of integers and validates such values.
        /// Finally, adds the values to the tree.
        /// </summary>
        /// <param name="input"></param>
        public void ProcessInput(string input)
        {
            ClearRoot();
            List<int> list = InputParser.GetIntegerList(input);

            list = ListValidator.GetValidList(list);
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                    AddNode(new BinaryTreeNode(list[i]));
            }
        }

        /// <summary>
        /// Method <c>GetPostOrderTraversal</c> runs over the tree to get
        /// all the existing values in it.
        /// </summary>
        /// <returns>A list of integers with all the values inside the tree</returns>
        public List<int> GetPostOrderTraversal()
        {
            List<int> result = new List<int>();

            if (_postOrderTraversal != null && Root != null)
            {
                result = _postOrderTraversal.Run(Root);
            }

            return result;
        }

        /// <summary>
        /// Method <c>ClearRoot</c> sets the root of a tree to null
        /// </summary>
        public void ClearRoot()
        {
            Root = null;
        }
    }
}
