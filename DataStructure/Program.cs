using System;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
           // LinkedList linkedlist = new LinkedList();
            Node node_1 = new Node(56);
            Node node_2 = new Node(30);
            Node node_3 = new Node(40);
            Node node_4 = new Node(70);

            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(40);
            linkedlist.Add(70);
            linkedlist.Display();
            Console.WriteLine("\nThe node is in ascending order");

        }
    }
}