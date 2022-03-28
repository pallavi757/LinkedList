using System;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            Console.WriteLine("First Created is 70");
            Node first_node = new Node(70);
            Console.WriteLine("Next 30 added");
            Node second_node = new Node(30);
            Console.WriteLine("Finally 56 is added");
            Node third_node = new Node(56);
            linkedlist.AddNode(first_node);
            linkedlist.AddNode(second_node);
            linkedlist.AddNode(third_node);
            linkedlist.Display();
        }
    }
}