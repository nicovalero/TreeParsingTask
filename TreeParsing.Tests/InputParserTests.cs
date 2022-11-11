using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeParsing.Classes;

namespace TreeParsing.Tests
{
    [TestClass]
    public class InputParserTests
    {
        [TestMethod]
        public void GetInteger_WhenInputIsNotNull_ReturnsNotNullIntegerList()
        {
            //Arrange
            string input = "";
            string input2 = "1";
            string input3 = "1,2,3,4,5,6";

            //Act
            List<int> list1 = InputParser.GetIntegerList(input);
            List<int> list2 = InputParser.GetIntegerList(input2);
            List<int> list3 = InputParser.GetIntegerList(input3);

            //Assert
            Assert.IsNotNull(list1);
            Assert.IsNotNull(list2);
            Assert.IsNotNull(list3);
        }

        [TestMethod]
        public void GetInteger_WhenInputIsNull_ReturnsNotNullIntegerList()
        {
            //Arrange
            string input = null;

            //Act
            List<int> list1 = InputParser.GetIntegerList(input);

            //Assert
            Assert.IsNotNull(list1);
        }

        [TestMethod]
        public void GetInteger_WhenInputContainsZeroOrMoreIntegers_ReturnsNotNullIntegerListWithSameAmountOfIntegers()
        {
            //Arrange
            string input = "";
            string input2 = "1";
            string input3 = "1,2,3,4,5,6";

            //Act
            List<int> list1 = InputParser.GetIntegerList(input);
            List<int> list2 = InputParser.GetIntegerList(input2);
            List<int> list3 = InputParser.GetIntegerList(input3);

            //Assert
            Assert.AreEqual(list1.Count,0);
            Assert.AreEqual(list2.Count, 1);
            Assert.AreEqual(list3.Count, 6);
        }

        [TestMethod]
        public void GetInteger_WhenListIsEitherNullOrNot_ReturnsListOfTypeInt()
        {
            //Arrange
            string input = "";
            string input2 = "1";
            string input3 = null;

            //Act
            List<int> list1 = InputParser.GetIntegerList(input);
            List<int> list2 = InputParser.GetIntegerList(input2);
            List<int> list3 = InputParser.GetIntegerList(input3);

            //Assert
            Assert.IsTrue(list1 is List<int>);
            Assert.IsTrue(list2 is List<int>);
            Assert.IsTrue(list3 is List<int>);
        }
    }
}
