using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Classes;

namespace TreeParsing.Tests
{
    [TestClass]
    public class ListValidatorTests
    {
        [TestMethod]
        public void GetValidList_WhenListIsNotNull_ReturnsNotNullIntegerList()
        {
            //Arrange
            List<int> list1 = new List<int>();

            List<int> list2 = new List<int>();
            list2.Add(1);

            List<int> list3 = new List<int>();
            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);

            //Act
            List<int> output1 = ListValidator.GetValidList(list1);
            List<int> output2 = ListValidator.GetValidList(list2);
            List<int> output3 = ListValidator.GetValidList(list3);

            //Assert
            Assert.IsNotNull(output1);
            Assert.IsNotNull(output2);
            Assert.IsNotNull(output3);
        }

        [TestMethod]
        public void GetValidList_WhenListIsNull_ReturnsNotNullIntegerList()
        {
            //Arrange
            List<int> list1 = null;

            //Act
            List<int> output1 = ListValidator.GetValidList(list1);

            //Assert
            Assert.IsNotNull(output1);
        }

        [TestMethod]
        public void GetValidList_WhenListContainsNonRepeatedIntegers_ReturnsUniqueIntegerList()
        {
            //Arrange
            List<int> list1 = new List<int>();
            list1.Add(1);

            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);

            HashSet<int> expectedoutput1 = new HashSet<int>();
            expectedoutput1.Add(1);

            HashSet<int> expectedoutput2 = new HashSet<int>();
            expectedoutput2.Add(1);
            expectedoutput2.Add(2);
            expectedoutput2.Add(3);
            expectedoutput2.Add(4);

            //Act
            List<int> output1 = ListValidator.GetValidList(list1);
            List<int> output2 = ListValidator.GetValidList(list2);

            //Assert
            Assert.AreEqual(expectedoutput1.Count, expectedoutput1.Count);
            Assert.AreEqual(expectedoutput2.Count, expectedoutput2.Count);

            for (int i = 0; i < output1.Count; i++)
            {
                Assert.IsTrue(expectedoutput1.Contains(output1[i]));
            }

            for (int i = 0; i < output2.Count; i++)
            {
                Assert.IsTrue(expectedoutput2.Contains(output2[i]));
            }
        }

        [TestMethod]
        public void GetValidList_WhenListContainsRepeatedIntegers_ReturnsUniqueIntegerList()
        {
            //Arrange
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);

            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(3);
            list2.Add(4);
            list2.Add(2);

            HashSet<int> expectedoutput1 = new HashSet<int>();
            expectedoutput1.Add(1);

            HashSet<int> expectedoutput2 = new HashSet<int>();
            expectedoutput2.Add(1);
            expectedoutput2.Add(2);
            expectedoutput2.Add(3);
            expectedoutput2.Add(4);

            //Act
            List<int> output1 = ListValidator.GetValidList(list1);
            List<int> output2 = ListValidator.GetValidList(list2);

            //Assert
            Assert.AreEqual(expectedoutput1.Count, expectedoutput1.Count);
            Assert.AreEqual(expectedoutput2.Count, expectedoutput2.Count);

            for(int i=0; i < output1.Count; i++)
            {
                Assert.IsTrue(expectedoutput1.Contains(output1[i]));
            }

            for (int i = 0; i < output2.Count; i++)
            {
                Assert.IsTrue(expectedoutput2.Contains(output2[i]));
            }
        }

        [TestMethod]
        public void GetValidList_WhetherListIsNullOrNot_RetunsListOfTypeInteger()
        {
            //Arrange
            List<int> list1 = new List<int>();
            list1.Add(1);

            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);

            List<int> list3 = null;

            //Act
            List<int> output1 = ListValidator.GetValidList(list1);
            List<int> output2 = ListValidator.GetValidList(list2);
            List<int> output3 = ListValidator.GetValidList(list3);

            //Assert
            Assert.IsTrue(output1 is List<int>);
            Assert.IsTrue(output2 is List<int>);
            Assert.IsTrue(output3 is List<int>);
        }
    }
}
