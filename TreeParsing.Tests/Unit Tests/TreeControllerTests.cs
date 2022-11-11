using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Classes;
using TreeParsing.Controller;
using TreeParsing.Interfaces;

namespace TreeParsing.Tests
{
    [TestClass]
    public class TreeControllerTests
    {
        [TestMethod]
        public void AddNode_WhenRootIsNull_ReturnsTrue()
        {
            //Arrange
            TreeController controller = new TreeController(new PostOrderTraversal());
            controller.Root = null;

            //Act
            bool result = controller.AddNode(new BinaryTreeNode(1));

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddNode_WhenRootIsNotNullANDTreeNodesAddNodeReturnsFalse_ReturnsFalse()
        {
            //Arrange
            var mockTreeNode = new Mock<BinaryTreeNode>(2, null, null);
            mockTreeNode.Setup(m => m.AddNode(It.IsAny<BinaryTreeNode>())).Returns(false);

            TreeController controller = new TreeController(new PostOrderTraversal());
            controller.Root = mockTreeNode.Object;

            //Act
            bool result = controller.AddNode(new BinaryTreeNode(1));

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddNode_WhenRootIsNotNullANDTreeNodesAddNodeReturnsTrue_ReturnsTrue()
        {
            //Arrange
            var mockTreeNode = new Mock<BinaryTreeNode>(2, null, null);
            mockTreeNode.Setup(m => m.AddNode(It.IsAny<BinaryTreeNode>())).Returns(true);

            TreeController controller = new TreeController(new PostOrderTraversal());
            controller.Root = mockTreeNode.Object;

            //Act
            bool result = controller.AddNode(new BinaryTreeNode(1));

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ProcessInput_WhenInputIsNotNullOrEmpty_UpdateTree()
        {
            //Arrange
            string input1 = "1,2,3,4";
            string input2 = "1";
            string input3 = "1,1,1,1,1";

            TreeController controller1 = new TreeController(new PostOrderTraversal());
            controller1.Root = null;

            TreeController controller2 = new TreeController(new PostOrderTraversal());
            controller2.Root = null;

            TreeController controller3 = new TreeController(new PostOrderTraversal());
            controller3.Root = null;

            //Act
            controller1.ProcessInput(input1);
            controller2.ProcessInput(input2);
            controller3.ProcessInput(input3);

            //Assert
            Assert.IsNotNull(controller1.Root);
            Assert.IsNotNull(controller2.Root);
            Assert.IsNotNull(controller3.Root);
        }

        [TestMethod]
        public void ProcessInput_WhenInputIsNullOrEmpty_UpdateTree()
        {
            //Arrange
            string input1 = null;
            string input2 = "";

            TreeController controller1 = new TreeController(new PostOrderTraversal());
            controller1.Root = null;

            TreeController controller2 = new TreeController(new PostOrderTraversal());
            controller2.Root = null;

            //Act
            controller1.ProcessInput(input1);
            controller2.ProcessInput(input2);

            //Assert
            Assert.IsNull(controller1.Root);
            Assert.IsNull(controller2.Root);
        }

        [TestMethod]
        public void ProcessInput_WhenInputDoesNotContainIntegers_UpdateTree()
        {
            //Arrange
            string input1 = "hello";

            TreeController controller1 = new TreeController(new PostOrderTraversal());
            controller1.Root = null;

            //Act
            controller1.ProcessInput(input1);

            //Assert
            Assert.IsNull(controller1.Root);
        }

        [TestMethod]
        public void GetPostOrderTraversal_WhenControllersRootIsNull_ReturnsEmptyList()
        {
            //Arrange
            TreeController controller1 = new TreeController(new PostOrderTraversal());
            controller1.Root = null;

            //Act
            List<int> traversal = controller1.GetPostOrderTraversal();

            //Assert
            Assert.IsNotNull(traversal);
        }

        [TestMethod]
        public void GetPostOrderTraversal_WhenControllersRootIsNotNull_ReturnsEmptyList()
        {
            //Arrange
            TreeController controller1 = new TreeController(new PostOrderTraversal());
            controller1.Root = new BinaryTreeNode(1);

            //Act
            List<int> traversal = controller1.GetPostOrderTraversal();

            //Assert
            Assert.IsNotNull(traversal);
        }

        [TestMethod]
        public void ClearRoot_SetsRootToNull()
        {
            //Arrange
            TreeController controller1 = new TreeController(new PostOrderTraversal());
            controller1.Root = new BinaryTreeNode(1);

            //Act
            controller1.ClearRoot();

            //Assert
            Assert.IsNull(controller1.Root);
        }
    }
}
