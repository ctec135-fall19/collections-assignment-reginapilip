using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    #region Assignment Details, IPO
     /*Author: Regina Pilipchuk
      CTEC135 Week 5
      Programming Assignment 4
      Problem 1: Arrays and List<T>  
      IPO:
      Simple array:
        - create an array of int of size 5
        - use a for loop to initialize it to the numbers 11 - 15
        - use a foreach loop to print out the values in the array
      List<T>
        - create a list of int
        - use a for loop to initialize the list to the numbers 21 - 25
        - use a foreach loop to print out the values in the list
        - update the values in the list to 31 - 35 using indexing
        - repeat the print using a for loop and indexing
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple array
            Console.WriteLine("=> Simple Array\n");
            // create an array of int of size 5
            int[] myArray = new int[5];
            // use a for loop to initialize it to the numbers 11-15
            for(int i = 0; i <myArray.Length; i++)
            {
                myArray[i] = i + 11;
            }
            // use a foreach loop to print out values in the array
            foreach(int element in myArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine();

            #region List<T>
            Console.WriteLine("=> List<T>\n");
            // create a list of int
            List<int> myList = new List<int>();
            Console.WriteLine("Initialized List:\n");
            // use a for loop to initialize the list to the numbers 21-25
            for(int i = 0; i < 5; i++)
            {
                myList.Add(i + 21);
            }
            // use a foreach loop to print out the values in the list
            foreach(int element in myList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine("Updated List using Indexing:\n");
            // update the values in the list to 31-35 using indexing
            myList[0] = 31;
            myList[1] = 32;
            myList[2] = 33;
            myList[3] = 34;
            myList[4] = 35;
            // repeat the print using a for loop and indexing
            for(int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
