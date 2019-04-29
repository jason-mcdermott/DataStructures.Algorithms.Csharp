using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Algorithms.Algorithms.Search
{
    public static class BinarySearch
    {
        // NOTE: Assumes input list of numbers is already sorted in ascending order

        public static bool IterativeSearch(IList<int> numbers, int target)
        {
            var mid = numbers.Count / 2;
            var left = numbers.Take(mid).ToList();
            var right = numbers.Skip(mid).Take(numbers.Count - left.Count).ToList();

            if (target <= left.Last())
            {
                foreach (var l in left)
                {
                    if (l == target)
                    {
                        return true;
                    }
                }
            }
            else if (target >= right.First())
            {
                foreach (var r in right)
                {
                    if (r == target)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool RecursiveSearch(IList<int> numbers, int target)
        {
            if (numbers.Count == 1 && numbers.First() == target)
            {
                return true;
            }

            if (target < numbers.First() || target > numbers.Last())
            {
                return false;
            }

            var mid = numbers.Count / 2;
            var left = numbers.Take(mid).ToList();
            var right = numbers.Skip(mid).Take(numbers.Count - left.Count).ToList();

            if (target <= left.Last())
            {
                return RecursiveSearch(left, target);
            }
            else if (target >= right.First())
            {
                return RecursiveSearch(right, target);
            }

            return false;
        }

        private static bool RecursiveSearch(int[] sorted, int target)
        {
            if (target < sorted[0] || target > sorted[sorted.Length - 1])
            {
                return false;
            }

            if (sorted.Length == 1 && sorted[0] == target)
            {
                return true;
            }

            var mid = sorted.Length / 2;
            var left = new int[mid];
            Array.Copy(sorted, left, mid);
            var right = new int[sorted.Length - left.Length];
            Array.Copy(sorted, mid, right, 0, sorted.Length - left.Length);

            if (target <= left[left.Length - 1])
            {
                return RecursiveSearch(left, target);
            }
            else if (target >= right[0])
            {
                return RecursiveSearch(right, target);
            }

            return false;
        }
    }
}
