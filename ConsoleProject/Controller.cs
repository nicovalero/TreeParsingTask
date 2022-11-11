using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Controller;
using TreeParsing.Interfaces;

namespace ConsoleProject
{
    internal class Controller
    {
        private TreeController _treeController;
        public TreeController TreeController { get { return _treeController; } set { _treeController = value; } }

        public Controller(TreeController treeController)
        {
            _treeController = treeController;
        }

        public string GetPostOrderTraversal()
        {
            List<int> list = _treeController.GetPostOrderTraversal();
            return String.Join(",",list);
        }

        public void ProcessInput(string input)
        {
            _treeController.ProcessInput(input);
        }
    }
}
