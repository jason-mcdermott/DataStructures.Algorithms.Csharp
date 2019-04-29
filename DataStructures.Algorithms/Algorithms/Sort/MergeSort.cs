using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Algorithms.Algorithms.Sort
{
    public static class MergeSort
    {
        public static IList<int> Sort(IList<int> input)
        {
            if (input.Count == 1)
            {
                return input;
            }

            var mid = input.Count / 2;
            var left = input.Take(mid).ToList();
            var right = input.Skip(mid).Take(input.Count - left.Count).ToList();

            return Merge(Sort(left), Sort(right));
        }

        public static IList<int> Merge(IList<int> left, IList<int> right)
        {
            var merged = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() < right.First())
                    {
                        merged.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        merged.Add(right.First());
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    merged.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    merged.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            return merged;
        }

        public static int[] Sort(int[] input)
        {
            if (input.Length == 1)
            {
                return input;
            }

            var mid = input.Length / 2;

            var left = new int[mid];
            Array.Copy(input, left, left.Length);

            var right = new int[input.Length - left.Length];
            Array.Copy(input, mid, right, 0, right.Length);

            return Merge(Sort(left), Sort(right));
        }

        public static int[] Merge(int[] left, int[] right)
        {
            var merged = new int[left.Length + right.Length];
            int index = 0;

            while (left.Length > 0 || right.Length > 0)
            {
                if (left.Length > 0 && right.Length > 0)
                {
                    if (left[0] < right[0])
                    {
                        merged[index] = left[0];
                        left = Slice(left);
                    }
                    else
                    {
                        merged[index] = right[0];
                        right = Slice(right);
                    }

                }
                else if (left.Length > 0)
                {
                    merged[index] = left[0];
                    left = Slice(left);
                }
                else
                {
                    merged[index] = right[0];
                    right = Slice(right);
                }

                index++;
            }

            return merged;
        }

        private static int[] Slice(int[] arr)
        {
            var temp = new int[arr.Length - 1];
            Array.Copy(arr, 1, temp, 0, temp.Length);
            
            return temp;
        }
        
        private static int Pop(this int[] arr)
        {
            var value = arr[0];

            var temp = new int[arr.Length-1];

            Array.Copy(arr, 1, temp, 0, temp.Length);
            arr = temp;

            return value;
        }
    }
}
