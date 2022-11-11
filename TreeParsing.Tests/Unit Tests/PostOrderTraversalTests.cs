using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Interfaces;
using TreeParsing.Classes;
using Moq;
using System.Xml.Linq;

namespace TreeParsing.Tests
{
    [TestClass]
    public class PostOrderTraversalTests
    {
        [TestMethod]
        public void Run_WhenRootIsNotNull_ReturnsList()
        {
            //Arrange
            TreeTraversal traversalObject = new PostOrderTraversal();
            TreeNode root = new BinaryTreeNode(1);

            TreeNode child1 = new BinaryTreeNode(1);
            TreeNode child2 = new BinaryTreeNode(3);
            TreeNode root2 = new BinaryTreeNode(2,(BinaryTreeNode)child1, (BinaryTreeNode)child2);

            //Act
            List<int> result1 = traversalObject.Run(root);
            List<int> result2 = traversalObject.Run(root2);

            //Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
        }

        [TestMethod]
        public void Run_WhenRootIsNull_ReturnsList()
        {
            //Arrange
            PostOrderTraversal traversalObject = new PostOrderTraversal();
            TreeNode root = null;

            //Act
            List<int> result1 = traversalObject.Run(root);

            //Assert
            Assert.IsNotNull(result1);
        }

        [TestMethod]
        public void Traverse_WhenNodeIsNotNull_SetsTraversalWithNoNullNode()
        {
            //Arrange
            int expectedNodeValue = 1;
            PostOrderTraversal traversalObject = new PostOrderTraversal();
            traversalObject.Traversal = new List<int>();
            TreeNode root = new BinaryTreeNode(expectedNodeValue);            

            //Act
            traversalObject.Traverse(root);

            //Assert
            Assert.IsNotNull(traversalObject.Traversal);
            Assert.IsTrue(traversalObject.Traversal[0] == 1);
        }

        [TestMethod]
        public void Traverse_WhenNodeIsNull_UpdatesTraversalWithNoNullNode()
        {
            //Arrange
            TreeNode root = null;
            PostOrderTraversal traversalObject = new PostOrderTraversal();
            traversalObject.Traversal = new List<int>();

            List<int> originalTraversal = traversalObject.Traversal;
            List<int> expectedTraversal = new List<int>();

            //Act
            traversalObject.Traverse(root);

            //Assert
            Assert.AreEqual(originalTraversal.Count, expectedTraversal.Count);

            for(int i = 0; i < originalTraversal.Count; i++)
            {
                Assert.AreEqual(originalTraversal[i], expectedTraversal[i]);
            }
        }
    }
}
