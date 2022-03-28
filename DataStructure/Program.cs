using System;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            Console.WriteLine("First Created is 56");
            Node first_node = new Node(56);
            linkedlist.AddNode(first_node);
            Console.WriteLine("\n Append a node 30 to 56");
            linkedlist.AppendNode(30);
            linkedlist.Display();
            Console.WriteLine("\n Append a node 70 to 30");
            linkedlist.AppendNode(70);      
            linkedlist.Display();
        }
    }
}