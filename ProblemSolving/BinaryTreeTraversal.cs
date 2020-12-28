using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class BinaryTreeTraversal
    {
        /* Class containing left and  
        right child of current 
        node and key value
        */
        class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        class BinaryTree
        {
            // Root of Binary Tree 
            Node root;

            BinaryTree()
            {
                root = null;
            }

            /* Given a binary tree, print  
               its nodes according to the 
               "bottom-up" postorder traversal. */
            void printPostorder(Node node)
            {
                if (node == null)
                    return;

                // first recur on left subtree 
                printPostorder(node.left);

                // then recur on right subtree 
                printPostorder(node.right);

                // now deal with the node 
                Console.Write(node.key + " ");
            }

            /* Given a binary tree, print  
               its nodes in inorder*/
            void printInorder(Node node)
            {
                if (node == null)
                    return;

                /* first recur on left child */
                printInorder(node.left);

                /* then print the data of node */
                Console.Write(node.key + " ");

                /* now recur on right child */
                printInorder(node.right);
            }

            /* Given a binary tree, print 
               its nodes in preorder*/
            void printPreorder(Node node)
            {
                if (node == null)
                    return;

                /* first print data of node */
                Console.Write(node.key + " ");

                /* then recur on left sutree */
                printPreorder(node.left);

                /* now recur on right subtree */
                printPreorder(node.right);
            }

            // Wrappers over above recursive functions 
            void printPostorder() { printPostorder(root); }
            void printInorder() { printInorder(root); }
            void printPreorder() { printPreorder(root); }

            //// Driver Code 
            //static public void Main(String[] args)
            //{
            //    BinaryTree tree = new BinaryTree();
            //    tree.root = new Node(1);
            //    tree.root.left = new Node(2);
            //    tree.root.right = new Node(3);
            //    tree.root.left.left = new Node(4);
            //    tree.root.left.right = new Node(5);

            //    Console.WriteLine("Preorder traversal " +
            //                       "of binary tree is ");
            //    tree.printPreorder();

            //    Console.WriteLine("\nInorder traversal " +
            //                        "of binary tree is ");
            //    tree.printInorder(); 

            //    Console.WriteLine("\nPostorder traversal " +
            //                          "of binary tree is ");
            //    tree.printPostorder();
            //}
        }
    }
}


//        /*
//         Binary tree: If the tree have 2 children for each node it has created then it is called binary tree
//	 A
//B		C

//Binary search tree: 
//It should be having 2 children for each node and
//1) left node should be less than equal to the root node and 
//2) right node should be greater th an or equal to root

//	2
//1		3

//Binary search tree can be traversed in 3 ways
//in Order : left root right
//pre order : root left right
//post order : left right root

//In Binary search tree In Order traversal give the sorted list.

//In Binary search tree the element can be added and searched with O(log n) complexity

//		10
//	7		 15
//5		9 13		20
//*/

class BinarySearchTree
{

    int data;
    BinarySearchTree left, right;
    BinarySearchTree(int _data)
    {
        this.data = _data;
        left = right = null;
    }

    // Inserting the element in Binary search tree
    public void Insert(int value)
    {
        if (value <= this.data)
        {
            // Add into left
            if (left == null)
            {
                left = new BinarySearchTree(value);
            }
            else
            {
                left.Insert(value);
            }
        }
        else
        {
            // Add into right
            if (right == null)
            {
                right = new BinarySearchTree(value);
            }
            else
            {
                right.Insert(value);
            }
        }
    }

    // Search functionality
    public bool Contains(int value)
    {
        if (this.data == value)
        {
            return true;
        }
        else if (value <= this.data)
        {
            if (left == null)
            {
                return false;
            }
            else
            {
                left.Contains(value);
            }
        }
        else
        {
            if (right == null)
            {
                return false;
            }
            else
            {
                right.Contains(value);
            }
        }
        return false;
    }

    // In Order print
    // Left Root Right
    public void PrintInOrder()
    {
        if (this.data == null)
        {
            return;
        }
        if (left != null)
        {
            left.PrintInOrder();
        }

        Console.WriteLine(this.data);

        if (right != null)
        {
            right.PrintInOrder();
        }
    }

    // Pre Order
    // Root Left Right
    public void PreOrderPrint()
    {
        if (this.data == null)
        {
            return;
        }
        Console.WriteLine(this.data);

        if (left != null)
        {
            left.PreOrderPrint();
        }

        if (right != null)
        {
            right.PreOrderPrint();
        }
    }

    // Post Order
    // Left Right Root
    public void PostOrderPrint()
    {
        if (this.data == null)
        {
            return;
        }
        if (left != null)
        {
            left.PreOrderPrint();
        }

        if (right != null)
        {
            right.PreOrderPrint();
        }

        Console.WriteLine(this.data);
    }
}