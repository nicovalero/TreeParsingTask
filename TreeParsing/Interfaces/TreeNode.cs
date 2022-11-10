using System;
using System.Collections.Generic;
using System.Text;

namespace TreeParsing.Interfaces
{
    public interface TreeNode
    {
        List<TreeNode> GetChildren();
        int Value { get; set; }
        bool AddNode(TreeNode node);
    }
}
