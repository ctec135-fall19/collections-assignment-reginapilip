using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    #region Assignment Details, IPO
    /*Author: Regina Pilipchuk
      CTEC135 Week 5
      Programming Assignment 4
      Problem 4: Linked List
      IPO:
      - Demonstrate use of constructor taking an IEnumerable object. Create a 
        string array having the first 5-10 words of your favorite nursery rhyme. 
        Use it as the argument when constructing the LinkedList object.
      - Print out the rhyme on a single line.
      - The traditional way to walk a linked list is to start at the head, 
        process the node, then set the node variable to the next node in the 
        list. Create a node variable and walk the list to print out the values.
        The line printed should be the same as the one above.
      - Remove a word from the middle of the list. Print the list on a single
        line to demonstrate this
      - Add the word back in and print the list again to demonstrate.
    */
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // demo use of constructor taking an IEnumerable object
            // create a string array having the first 5-10 words of your favorite
            // nursery rhyme. Use it as the argument when constructing
            // the LinkedList object
            Console.WriteLine("=> Linked Lists\n");
            // create a simple array
            string[] myStrArray = new string[]
                {"Twinkle", "Twinkle", "Little", "Star", 
                 "How", "I", "Wonder", "Where", "You", "Are"};

            // create a linked list
            LinkedList<string> lList = new LinkedList<string>(myStrArray);
            // print out the rhyme on a single line using a while loop
            Console.WriteLine("Printing New List:");
            LinkedListNode<string> node = lList.First;
            PrintList(lList, node);
            Console.WriteLine();

            // remove a word from the middle of the list. 
            Console.WriteLine("Removing \"Little\":");
            node = lList.Find("Little");
            lList.Remove(node);
            node = lList.First;
            // print the list on single line to demo this
            PrintList(lList, node);
            Console.WriteLine();

            // add the word back in
            Console.WriteLine("Adding \"Little\" Back:");
            node = lList.FindLast("Twinkle");
            lList.AddAfter(node, "Little".ToUpper());
            node = lList.First;
            // print list again to demo
            PrintList(lList, node);
            Console.WriteLine();
        }
        
        // method to print
        public static void PrintList(LinkedList<string> lList, LinkedListNode<string> node)
        {
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
