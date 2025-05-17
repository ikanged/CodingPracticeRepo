using System;
using System.Collections;
using CodingPractice.Helpers;

namespace CodingPractice.Problems.Other_Code_Problems
{
    class BSTCheck : AbsProblem, IProblem
    {
        UserInput _userInput = new UserInput();
        Hashtable typeCollection = new Hashtable();

        public BSTCheck() : base("Binary Search Tree Check")
        {

        }

        public override void Begin()
        {
            BinarySearchTree<int> IntTree = new BinarySearchTree<int>();
            BinarySearchTree<string> StringTree = new BinarySearchTree<string>();
            
            switch (DisplayBinaryTreeTypeChoice())
			{
                case 1:
                    IntTree.Root.Value = 10;
                    IntTree.Root.left.Value = 7;
                    IntTree.Root.left.left.Value = 6;
                    IntTree.Root.left.right.Value = 8;
                    IntTree.Root.left.left.left.Value = 1;
                    IntTree.Root.left.right.right.Value = 9;

                    IntTree.Root.right.Value = 11;
                    IntTree.Root.right.right.Value = 20;
                    IntTree.Root.right.right.left.Value = 14;
                    IntTree.Root.right.right.right.Value = 22;

                    if (IntTree.checkTree(IntTree.Root, null, null))
                    {
                        DisplayMessage("true");
                    }
                    else
                    {
                        DisplayMessage("false");
                    }

                    DisplayMessage($"PreOrder Traversal: ");
                    Console.WriteLine($"{IntTree.PreOrderTraversal(IntTree.Root, "")}");

                    DisplayMessage("\nInOrder Traversal: ");
                    Console.WriteLine($"{IntTree.InOrderTraversal(IntTree.Root, "")}");

                    DisplayMessage("\nPostOrder Traversal: ");
                    Console.WriteLine($"{IntTree.PostOrderTraversal(IntTree.Root, "")}");
                    break;
                case 2:
                    StringTree.Root.Value = "First";
                    StringTree.Root.left.Value = "Third";
                    StringTree.Root.left.left.Value = "Fourth";
                    StringTree.Root.right.Value = "Apples";
                    StringTree.Root.right.Value = "Testing1";
                    StringTree.Root.right.right.Value = "Cars";

                    if (StringTree.checkTree(StringTree.Root, null, null))
                    {
                        DisplayMessage("true");
                    }
                    else
                    {
                        DisplayMessage("false");
                    }

                    DisplayMessage($"PreOrder Traversal: ");
                    Console.WriteLine($"{StringTree.PreOrderTraversal(StringTree.Root, "")}");

                    DisplayMessage("\nInOrder Traversal: ");
                    Console.WriteLine($"{StringTree.InOrderTraversal(StringTree.Root, "")}");

                    DisplayMessage("\nPostOrder Traversal: ");
                    Console.WriteLine($"{StringTree.PostOrderTraversal(StringTree.Root, "")}");
                    break;

            }

            //DisplayMessage("\nSerialized Tree:");
            //Console.WriteLine($"{IntTree.Serialize(IntTree.Root, "")}");

            DisplayMessage("\nDeSerialied Tree");
            //IntTree.Deserialize();
        }

        private int DisplayBinaryTreeTypeChoice()
        {
            InitializeTypeTable();
            DisplayMessage("Which Binary type to use?");

            foreach (var type in typeCollection.Keys)
            {
                DisplayMessage($"{type}. {typeCollection[type]}");
            }

            return GetUserIntInput();
        }

        private void InitializeTypeTable()
        {
            typeCollection.Add(1, "Int");
            typeCollection.Add(2, "String");
        }
    }
}