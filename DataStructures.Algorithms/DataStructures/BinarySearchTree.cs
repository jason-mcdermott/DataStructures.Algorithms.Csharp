using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithms.DataStructures.Trees
{
    public class BinarySearchTree
    {
        public class Node<T>
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; set; }

            public Node<T> Left { get; set; }

            public Node<T> Right { get; set; }
        }

        public void Delete(Node<int> node, Node<int> target)
        {
            /* Base Case: If the tree is empty */
            if (node == null)
            {
                return;
            }

            /* Otherwise, recur down the tree */
            if (target.Value < node.Value)
            {
                Delete(node.Left, target);
            }
            else if (target.Value > node.Value)
            {
                Delete(node.Right, target);
            }


            // if key is same as root's key, then it is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (node.Left == null)
                {
                    Delete(node.Right, target);
                    //return root.right;
                }
                else if (node.Right == null)
                {
                    Delete(node.Left, target);
                    //return root.left;
                }


                // node with two children: Get the 
                // inorder successor (smallest  
                // in the right subtree)  
                node.Value = FindMin(node.Right);

                // Delete the inorder successor  
                Delete(node.Right, node);
            }
            //return root;
        }
        public Node<int> Insert(Node<int> node, Node<int> target)
        {
            if (node == null)
            {
                node = target;
            }
            else
            {
                // insert to the left
                if (target.Value < node.Value)
                {
                    node.Left = Insert(node.Left, target);
                }
                // or  insert to the right
                else if (target.Value > node.Value)
                {
                    node.Right = Insert(node.Right, target);
                }
            }

            return node;
        }

        public void Remove(Node<int> node, Node<int> target)
        {
            if (node == null)
            {
                return;
            }

            // target is to the left of current node
            if (target.Value < node.Value)
            {
                // traverse left
                Remove(node.Left, target);
            }
            // target is to the right of current node
            else if (target.Value > node.Value)
            {
                // traverse right
                Remove(node.Right, target);
            }
            // current node has two children
            else if (node.Left != null && node.Right != null)
            {
                // set current node value to minimum to the right
                node.Value = FindMin(node.Right);

                Remove(node.Right, node);
            }
            else
            {
                node = (node.Left != null) ? node.Left : node.Right;
            }
        }

        public int GetLeafCount(Node<int> node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.Left == null && node.Right == null)
            {
                return 1;
            }
            else
            {
                return GetLeafCount(node.Left) + GetLeafCount(node.Right);
            }
        }

        public int MaxDepth(Node<int> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                // compute the depth of each subtree 
                int leftDepth = MaxDepth(node.Left);
                int rightDepth = MaxDepth(node.Right);

                // take the larger one
                if (leftDepth > rightDepth)
                {
                    return (leftDepth + 1);
                }
                else
                {
                    return (rightDepth + 1);
                }
            }
        }

        public int FindMin(Node<int> root)
        {
            int min = root.Value;

            while (root.Left != null)
            {
                min = root.Left.Value;
                root = root.Left;
            }

            return min;
        }

        private List<int> _nodeList { get; set; } = new List<int>();

        public void PreOrderTraversal2(Node<int> root)
        {
            if (root != null)
            {
                _nodeList.Add(root.Value);
                PreOrderTraversal2(root.Left);
                PreOrderTraversal2(root.Right);
            }

            // 20 15 13 16 25 22 45
        }

        public void InOrderTraversal2(Node<int> root)
        {
            if (root != null)
            {
                InOrderTraversal2(root.Left);
                _nodeList.Add(root.Value);
                InOrderTraversal2(root.Right);
            }

            // 13 15 16 20 22 25 45
        }

        public void PostOrderTraversal2(Node<int> root)
        {
            if (root != null)
            {
                PostOrderTraversal2(root.Left);
                PostOrderTraversal2(root.Right);
                _nodeList.Add(root.Value);
            }

            // 13 16 15 22 45 25 20
        }
    }
}
