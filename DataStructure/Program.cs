using System;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            Node first_node = new Node(70);
            linkedlist.AddNode(first_node);
            linkedlist.AddNodeInbetween(30);
            Node last_node = new Node(56);
            linkedlist.AddNode(last_node);
           // linkedlist.Display();
            // Console.WriteLine("Deleting first node");
            // linkedlist.DeleteFirstNode();
            // linkedlist.Display();
            //  Console.WriteLine("\n Deleting last node");
            //  linkedlist.DeleteLastNode();
            //  linkedlist.Display();

            Console.WriteLine("Enter Number want to Search");
            int data = int.Parse(Console.ReadLine());
            bool res = linkedlist.search(data);
            if (res == true)
            {
                Console.WriteLine("Data is found");
            }
            else
            {
                Console.WriteLine("Data is not found");
            }
            linkedlist.Display();
        }
    }
}