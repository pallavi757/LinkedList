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
            linkedlist.Display();
        }
    }
}