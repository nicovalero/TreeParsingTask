using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Controller;
using TreeParsing.Interfaces;

namespace ConsoleProject
{
    /// <summary>
    /// Class <c>Controller</c> defines an object to interact between
    /// the user input and the controller responsible to create the tree
    /// </summary>
    internal class Controller
    {
        private TreeController _treeController;
        public TreeController TreeController { get { return _treeController; } set { _treeController = value; } }

        public Controller(TreeController treeController)
        {
            _treeController = treeController;
        }

        /// <summary>
        /// Method <c>GetPostOrderTraversal</c> obtains a list of integers
        /// after running the tree using the post-order traversal.
        /// Then joins all the values in a comma-separated string.
        /// </summary>
        /// <returns>String with all the values in a tree, separated by commas.</returns>
        public string GetPostOrderTraversal()
        {
            List<int> list = _treeController.GetPostOrderTraversal();
            return String.Join(",",list);
        }

        /// <summary>
        /// Method <c>ProcessInput</c> obtains the raw input of the user
        /// and process it with the help of TreeController.
        /// </summary>
        /// <param name="input"></param>
        public void ProcessInput(string input)
        {
            _treeController.ProcessInput(input);
        }
    }
}
