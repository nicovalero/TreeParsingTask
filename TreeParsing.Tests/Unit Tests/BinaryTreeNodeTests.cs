using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using TreeParsing.Classes;
using TreeParsing.Interfaces;

namespace TreeParsing.Tests
{
    [TestClass]
    public class BinaryTreeNodeTests
    {
        [TestMethod]
        public void GetChildren_WhenPropertyChildrenIsNotNull_ReturnsList()
        {
            //Arrange
            BinaryTreeNode node = new BinaryTreeNode(1);

            //Act
            List<TreeNode> result = node.GetChildren();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetChildren_WhenLeftOrRightAreNotNull_ReturnsNonEmptyList()
        {
            //Arrange
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode right1 = new BinaryTreeNode(2);

            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode left2 = new BinaryTreeNode(1);

            BinaryTreeNode node3 = new BinaryTreeNode(2);
            BinaryTreeNode left3 = new BinaryTreeNode(1);
            BinaryTreeNode right3 = new BinaryTreeNode(3);

            //Act
            List<TreeNode> result1 = node1.GetChildren();
            List<TreeNode> result2 = node2.GetChildren();
            List<TreeNode> result3 = node3.GetChildren();

            //Assert
            Assert.IsTrue(result1.Count > 0);
            Assert.IsTrue(result2.Count > 0);
            Assert.IsTrue(result3.Count > 0);
        }

        [TestMethod]
        public void AddNode_WhenNodeIsNotBinaryTreeNode_ReturnsFalse()
        {
            //Arrange
            TreeNode root = new BinaryTreeNode(1);
            TreeNode node = null;

            //Act
            bool result1 = root.AddNode(node);

            //Assert
            Assert.IsFalse(result1);
        }

        [TestMethod]
        public void AddNode_WhenNodeIsBinaryTreeNodeANDValueNotPresentInTree_ReturnsTrue()
        {
            //Arrange
            TreeNode root1 = new BinaryTreeNode(1);
            TreeNode node1 = new BinaryTreeNode(2);

            TreeNode root2 = new BinaryTreeNode(2);
            TreeNode node2 = new BinaryTreeNode(1);

            //Act
            bool result1 = root1.AddNode(node1);
            bool result2 = root2.AddNode(node2);

            //Assert
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void AddNode_WhenNodeIsBinaryTreeNodeANDValuePresentInTree_ReturnsFalse()
        {
            //Arrange
            int value1 = 1;
            TreeNode root1 = new BinaryTreeNode(value1);
            TreeNode node1 = new BinaryTreeNode(value1);

            //Act
            bool result1 = root1.AddNode(node1);

            //Assert
            Assert.IsFalse(result1);
        }
    }
}
