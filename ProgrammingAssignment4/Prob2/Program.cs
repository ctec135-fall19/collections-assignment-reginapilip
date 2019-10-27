using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    #region Assignment Details, IPO
    /*Author: Regina Pilipchuk
      CTEC135 Week 5
      Programming Assignment 4
      Problem 2: Stacks and Queues
      IPO:
      Stack
        - declare and initialize a stack with the numbers 1 - 5 
          using initialization syntax.
        - demonstrate use of the enumerator to print out the members 
          in the stack, i.e. write a foreach loop
        - print a peek at the top member in the stack
        - write a loop that pops the elements off of the stack and prints each
        Queue
        - declare a queue
        - initialize the queue with the numbers 1-5 using a for loop.
        - demonstrate use of the enumerator to print out the members in the queue, 
          i.e. write a foreach loop
        - print a peek at the top member in the stack
        - write a loop that dequeues the elements from the stack and prints each
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region stacks
            Console.WriteLine("=> Stack\n");
            // declare a stack
            Stack<int> myStack = new Stack<int>();
            // initialize a stack with the numbers 1 - 5 using 
            // initialization syntax
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            // demo use of the enumerator to print out the members in the stack
            // i.e. write a foreach loop
            Console.WriteLine("Notice the order of the Stack (LIFO)");
            foreach (int element in myStack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            // print a peek at the top member in the stack
            Console.WriteLine("Stack Peeking:\n" +
                                "{0}", myStack.Peek());
            // write a loop that pops the elements off of the stack 
            // and prints each
            // create a variable that holds the size of the object
            Console.WriteLine();
            Console.WriteLine("Stack Popping:");
            int size = myStack.Count;
            for(int i = 0; i < size; i++ )
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine("\nStack Count After Popping: {0}",myStack.Count);
            Console.WriteLine();
            #endregion

            Console.WriteLine();

            #region queues
            Console.WriteLine("=> Queue\n");
            Console.WriteLine("Notice the order of the Queue (FIFO)");
            // declare a queue
            Queue<int> myQueue = new Queue<int>();
            // initialize the queue with the numbers 1-5 using a for loop
            for(int i = 0; i < 5; i++)
            {
                myQueue.Enqueue(i + 1);
            }
            // demo use of the enumerator to print out the members in the queue
            // i.e. write a foreach loop
            foreach(int element in myQueue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            // print a peek at the top member in the queue
            Console.WriteLine("Queue Peeking:\n{0}", myQueue.Peek());
            // write a loop that dequeues the elements from the queue and 
            // prints each
            Console.WriteLine();
            Console.WriteLine("Dequeuing:");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine();
            Console.WriteLine("Queue after Dequeuing: {0}", myQueue.Count);
            Console.WriteLine();
            #endregion
        }
    }
}
