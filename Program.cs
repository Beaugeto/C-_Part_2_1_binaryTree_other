using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTreeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************************************
            // Binary Tree of integers
            ********************************************************************************/
            // 1. Declare data variables needed for this program
            // Create a binary tree and insert 10 elements
            // (one is a duplicate and will be ignored)
            BinaryTree<int> btIntegers = new BinaryTree<int>(); // added BinrayTree.cs as class file

            // display header
            Console.WriteLine("**********************************************");
            Console.WriteLine("********** Binary Tree<int> Example **********");
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            // 2. Add integer values to the binary tree btIntegers
            // Order of insertion: 16, 24, 15, 13, 18, 56, 13, 19, 17
            btIntegers.Add(16);
            btIntegers.Add(24);
            btIntegers.Add(15);
            btIntegers.Add(13);
            btIntegers.Add(18);
            btIntegers.Add(56);
            btIntegers.Add(13);
            btIntegers.Add(19);
            btIntegers.Add(17);

            Console.WriteLine();

            // 3. Display binary tree details
            Console.WriteLine("Binary tree node insertion complete!");
            Console.WriteLine("There are " + btIntegers.GetCount() + " nodes in total");
            Console.WriteLine(" Height of binary tree is: " + btIntegers.GetHeight(btIntegers.GetRoot()));

            Console.WriteLine("************************************************");

            // display elements using a breadth-first traversal method
            // code utilises a queue (FIFO data structure) to implement this method
            // displaying data in each node moving left to right
            // level 0 is where the root node lies (containing the value of 16)
            // level 1 is where root's left child and root's right child exists

            Console.WriteLine("Breadth-First traversal if elements using queue ...");
            btIntegers.DisplayBreathFirst();
            Console.WriteLine();

            Console.WriteLine("************************************************");

            // display elements using the standard depth-first traversal method
            // code utilises a stack (FILO data structure) to implement this method
            // displaying data in each node moving down the node's right side
            // using the priority of Root-R-L
            Console.WriteLine("Depth-First traversal using stack (Root-R-L) ...");
            btIntegers.DisplayDepthFirst();
            Console.WriteLine();

            Console.WriteLine("************************************************");

            // display elements in the numerical order
            Console.WriteLine("Inorder traversal of elements (L-Root-R) ...");
            btIntegers.NodeValues = "";
            btIntegers.Inorder(btIntegers.GetRoot());
            Console.WriteLine(btIntegers.NodeValues);
            Console.WriteLine();

            Console.WriteLine("************************************************");

            // display elements preorder which means traversing the list from
            // root along the left side first (left side holds all values < root)
            // then traversing the right side last (which holds all values > root)
            // e.g 16 (root) - 15 - 13 (left)- 24 - 18 - 17 - 19 - 56 (right)
            Console.WriteLine("Preorder traversal of elements (Root-L-R) ... ");
            btIntegers.NodeValues = "";
            btIntegers.Preorder(btIntegers.GetRoot());
            Console.WriteLine(btIntegers.NodeValues);
            Console.WriteLine();

            Console.WriteLine("************************************************");

            // display elements starting with left side first (not root) in reverse
            // then following on the right side; finally ending on the root 
            // e.g 13 - 15 (left reverse) - 17 - 19 - 18 - 56 - 24 - 16 (right reverse)
            // - 16 (root)
            Console.WriteLine("Postorder traversal of elements (L-R-Root) ... ");
            btIntegers.NodeValues = "";
            btIntegers.Postorder(btIntegers.GetRoot());
            Console.WriteLine(btIntegers.NodeValues);
            Console.WriteLine();

            Console.WriteLine("************************************************");

            Console.Write("Enter a value to search ===> ");
            int valueToSearch = Int32.Parse(Console.ReadLine());
            Console.WriteLine();


            if (btIntegers.Contains(valueToSearch))
            {
                Console.WriteLine(valueToSearch + " found!");

            }
            else
            {
                Console.WriteLine(valueToSearch + " not found!");
            }

            Console.WriteLine();



            Console.WriteLine("************************************************");
            Console.WriteLine("********  Binary Tree<string> Example  *********");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            BinaryTree<string> btFilms = new BinaryTree<string>();
            btFilms.Add("Howl's Moving Castle");
            btFilms.Add("Spirited Away");
            btFilms.Add("Princess Mononoke");
            btFilms.Add("My Neighbour Totoro");
            btFilms.Add("Nausicca of the Valley of the Wind");
            Console.WriteLine();

            // Display list in alphabetical order
            Console.WriteLine("Inorder traversal of strings ...");
            btFilms.Inorder(btFilms.GetRoot());
            Console.WriteLine(btFilms.NodeValues);
            Console.WriteLine();



            Console.WriteLine("************************************************");
            Console.WriteLine("*******  Binary Tree<DateTime> Example  ********");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            BinaryTree<DateTime> btDates = new BinaryTree<DateTime>();
            btDates.Add(new DateTime(2000, 1, 1));
            btDates.Add(new DateTime(2025, 12, 25)); // future date-time
            btDates.Add(DateTime.Today); // current date-time
            btDates.Add(new DateTime(1995, 3, 14)); // past date-time
            btDates.Add(DateTime.Today.AddDays(-1)); // yesterday's date-time
            Console.WriteLine();

            // Display list in alphabetical order
            Console.WriteLine("In-order traversal of dates ...");
            btDates.Inorder(btDates.GetRoot());
            Console.WriteLine(btDates.NodeValues);
            Console.WriteLine();


            Console.WriteLine("************************************************");
            Console.WriteLine("********  Binary Tree<Friend> Example  *********");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            BinaryTree<Friend> btFriend = new BinaryTree<Friend>();
            // Create a Binary Tree data structure named "btFriends"
            // using the provided Friend class
            // Add the cast of the television series "Friends"
            // Jennifer Aniston - born 02-Nov-1969
            btFriend.Add(new Friend("Jennifer", "Aniston", new DateTime(1969, 11, 02)));
            // Courtney Cox - born 15-Jun-1964
            btFriend.Add(new Friend("Courtney", "Cox", new DateTime(1964, 06, 15)));
            // Lisa Kudrow - born 30-Jul-1963
            btFriend.Add(new Friend("Lisa", "Kudrow", new DateTime(1963, 07, 30)));
            // Matt LeBlanc - born 25-Jul-1967
            btFriend.Add(new Friend("Matt", "LeBlanc", new DateTime(1967, 07, 25)));
            // Matthew Perry - born 19-Aug-1969
            btFriend.Add(new Friend("Matthew", "Perry", new DateTime(1969, 08, 19)));
            // David Schwimmer - born 02-Nov-1966
            btFriend.Add(new Friend("David", "Schwimmer", new DateTime(1966, 11, 02)));
            Console.WriteLine();


            Console.WriteLine("************************************************");
            Console.WriteLine("*****  Binary Tree<MathQuestions> Example  *****");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            BinaryTree<MathQuestion> btMathQuiz = new BinaryTree<MathQuestion>();
            // Create a Binary Tree data structure named "btMathQuiz"
            // using the provided MathQuestion class
            // Create new MathQuestion instances for the following and add them to the
            // btMathQuiz binary tree
            btMathQuiz.Add(new MathQuestion(11, "-", 6, 5));
            btMathQuiz.Add(new MathQuestion(15, "-", 6, 9));
            btMathQuiz.Add(new MathQuestion(20, "/", 2, 10));
            btMathQuiz.Add(new MathQuestion(10, "+", 2, 12));
            btMathQuiz.Add(new MathQuestion(7, "+", 6, 13));
            btMathQuiz.Add(new MathQuestion(7, "*", 2, 14));
            btMathQuiz.Add(new MathQuestion(11, "+", 4, 15));
            btMathQuiz.Add(new MathQuestion(4, "*", 4, 16));

            Console.WriteLine();


            // In-order traversal of the MathQuestion binary tree
            Console.WriteLine("In-order traversal of MathQuestion  ...");
            btMathQuiz.NodeValues = "";
            btMathQuiz.Inorder(btMathQuiz.GetRoot());
            Console.WriteLine(btMathQuiz.NodeValues);
            Console.WriteLine();

        }
    }
}
