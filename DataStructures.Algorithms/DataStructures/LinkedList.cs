using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithms.DataStructures.Lists
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void Add(T value)
        {
            var node = new Node<T>(value);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                var temp = GetLast();
                temp.Next = node;
            }
        }

        public void Traverse()
        {
            var current = Head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public Node<T> GetLast()
        {
            Node<T> temp = default(Node<T>);

            var current = Head;

            while (current != null)
            {
                temp = current;
                current = current.Next;
            }

            return temp;
        }
    }

    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public Node<T> Next { get; set; }
        public T Value { get; set; }
    }


}
