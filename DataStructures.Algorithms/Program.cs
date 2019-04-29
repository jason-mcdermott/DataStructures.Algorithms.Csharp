using System;
using System.Collections.Generic;
using static DataStructures.Algorithms.Algorithms.Sort.MergeSort;

namespace DataStructures.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsorted = new int[] { 3, 5, 2, 9, 10, 8, 1, 4, 6, 7};

            var sorted = Sort(unsorted);
        }
    }
}
