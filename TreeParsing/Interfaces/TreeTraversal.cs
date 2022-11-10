using System;
using System.Collections.Generic;
using System.Text;

namespace TreeParsing.Interfaces
{
    public interface TreeTraversal
    {
        public List<int> Run(TreeNode root);
    }
}
