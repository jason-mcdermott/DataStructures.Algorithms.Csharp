using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DataStructures.Algorithms.Algorithms.Sort.MergeSort;

namespace Algorithms.UnitTests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void MergeSort_using_returns_sorted_list()
        {
            // arrange
            var unsorted = new List<int> { 3, 5, 2, 9, 10, 8, 1, 4, 6, 7 };

            // act
            var sorted = Sort(unsorted);

            // assert
            Assert.AreEqual(1, sorted[0]);
            Assert.AreEqual(2, sorted[1]);
            Assert.AreEqual(5, sorted[4]);
            Assert.AreEqual(7, sorted[6]);
            Assert.AreEqual(10, sorted[9]);
        }

        [TestMethod]
        public void MergeSort_using_returns_sorted_array()
        {
            // arrange
            var unsorted = new int[] { 3, 5, 2, 9, 10, 8, 1, 4, 6, 7 };

            // act
            var sorted = Sort(unsorted);

            // assert
            Assert.AreEqual(1, sorted[0]);
            Assert.AreEqual(2, sorted[1]);
            Assert.AreEqual(5, sorted[4]);
            Assert.AreEqual(7, sorted[6]);
            Assert.AreEqual(10, sorted[9]);
        }
    }
}
