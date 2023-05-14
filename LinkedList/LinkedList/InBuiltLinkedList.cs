using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class InBuiltLinkedList
    {
        public void CurdLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add items to the LinkedList
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);

            // Print the items in the LinkedList
            Console.WriteLine("Items in the LinkedList:");
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Insert an item at a specific index in the LinkedList
            linkedList.AddBefore(linkedList.Find(3), 10);

            // Print the items in the LinkedList after inserting an item
            Console.WriteLine("Items in the LinkedList after inserting an item:");
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Remove an item from the LinkedList
            linkedList.Remove(2);

            // Print the items in the LinkedList after removing an item
            Console.WriteLine("Items in the LinkedList after removing an item:");
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Update an item in the LinkedList
            linkedList.Find(4).Value = 20;

            // Print the items in the LinkedList after updating an item
            Console.WriteLine("Items in the LinkedList after updating an item:");
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Clear the LinkedList
            linkedList.Clear();

            // Print the items in the LinkedList after clearing it
            Console.WriteLine("Items in the LinkedList after clearing it:");
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

    

    }
}
