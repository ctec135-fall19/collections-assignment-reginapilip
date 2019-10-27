using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    #region Assignment Details, IPO
    /*Author: Regina Pilipchuk
      CTEC135 Week 5
      Programming Assignment 4
      Problem 3: Dictionary
      IPO:
      - declare a dictionary and initialization it to create 3 entries: 
        (1, "one"), (2, "two"), and (3, "three"). Use a combination of 
        initialization syntax, Add() and [] in your initialization code.
      - add an additional entry: (99, "ninety-nine")
      - show use of enumerator to see all entries. Print both the key and value
      - reassign the value of 99 to "99" using indexing notation
      - print the new value using indexing notation
      - remove the 2 item and enumerate over the whole dictionary to show it's gone
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Dictionary\n");
            // declare a dictionary and initialize it to create 3 entries:
            // (int, string): (1, "one"), (2, "two"), (3, "three")
            // use a combination of the following in your initialization code
            //  - initialization syntax
            //  - Add()
            //  - []
            Dictionary<int, string> numDictionary = new Dictionary<int, string>();
            numDictionary.Add(1, "one");
            numDictionary.Add(2, "two");
            numDictionary[3] = "three";
            // add an additional entry: (99, "ninety-nine")
            numDictionary[99] = "ninety-nine";
            // show use of enumerator to see all entries. Print both the
            // key and value
            // printing key
            Console.WriteLine("Keys and Values of numDictionary");
            PrintDictionary(numDictionary);
            // reassign the value of 99 to "99" using indexing notation
            // print the new value using indexing notation 
            Console.WriteLine("Reassigned Value for Key 99:");
            Console.WriteLine(numDictionary[99] = "99");
            Console.WriteLine();
            // remove the 2 item and enumerate over the whole 
            // dictionary to show it's gone
            Console.WriteLine("Removing 2nd Item:");
            numDictionary.Remove(2);
            PrintDictionary(numDictionary);
        }

        /*
        NOTE: Bill, I attempted to create  a method that would print
              the keys and values of numDictionary. I'd love to hear your
              feedback on how I did. Want to make sure I did it correctly 
              and also if that was the appropriate thing to do.
              Thanks!
        */
        public static void PrintDictionary(Dictionary<int, string> numDictionary)
        {
            // printing key
            foreach (int key in numDictionary.Keys)
            {
                Console.WriteLine("Key:\t{0}", key);
            }
            // printing value
            foreach (string value in numDictionary.Values)
            {
                Console.WriteLine("Value:\t{0}", value);
            }
            Console.WriteLine();
        }
    }
}
