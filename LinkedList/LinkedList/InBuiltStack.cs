using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class InBuiltStack
    {
        public void CurdStack()
        {
            Stack stack = new Stack();

            // Adding elements to the stack
            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Mango");

            Console.WriteLine("Stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Reading the top element of the stack without removing it
            Console.WriteLine("\nThe top element is: " + stack.Peek());

            // Removing the top element of the stack
            Console.WriteLine("\nPopped element: {0}", stack.Pop());


            // Checking if the stack contains a certain element
            Console.WriteLine("\nThe stack contains Banana: " + stack.Contains("Banana"));

            // Clearing the stack
            stack.Clear();
            Console.WriteLine("\nStack After clear:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
