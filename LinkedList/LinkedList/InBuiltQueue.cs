using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class InBuiltQueue
    {
        public void CurdQueue()
        {
            Queue queue = new Queue();

            // Add elements to the queue
            queue.Enqueue("apple");
            queue.Enqueue("banana");
            queue.Enqueue("cherry");
            queue.Enqueue("Mango");

            // Print the queue
            Console.WriteLine("Queue elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            // Dequeue an element
            string removedElement = (string)queue.Dequeue();
            Console.WriteLine("\nDequeued element: " + removedElement);

            Console.WriteLine("\nQueue after Dequeue elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Peek at the first element
            string firstElement = (string)queue.Peek();
            Console.WriteLine("\nFirst element: " + firstElement);

            // Check if an element is in the queue
            Console.WriteLine("\nThe Queue contains Banana: " + queue.Contains("banana"));

            // Clear the queue
            queue.Clear();

            Console.WriteLine("\nQueue elements after clear:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }

    }
}
