using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
                
            }
            
            else
            {
                node.next = Head;
                Head = node;
            }         
        }

        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }

        public void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Console.WriteLine("Linked List as follws");
            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
        }
    }
}
