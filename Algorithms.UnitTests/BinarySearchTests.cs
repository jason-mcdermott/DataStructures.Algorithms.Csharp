using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DataStructures.Algorithms.Algorithms.Search.BinarySearch;

namespace Algorithms.UnitTests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void Iterative_BinarySearch_locates_target_in_list()
        {
            // arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // act
            bool found = IterativeSearch(numbers, 5);

            // assert
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Recursive_BinarySearch_locates_target_in_list()
        {
            // arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // act
            bool found = RecursiveSearch(numbers, 5);

            // assert
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Iterative_BinarySearch_identifies_when_target_is_not_in_list()
        {
            // arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // act
            bool found = IterativeSearch(numbers, 0);

            // assert
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void Recursive_BinarySearch_identifies_when_target_is_not_in_list()
        {
            // arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // act
            bool found = RecursiveSearch(numbers, 0);

            // assert
            Assert.IsFalse(found);
        }
    }
}
