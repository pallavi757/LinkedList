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
        public void AddNodeInbetween(int data)
        {

            Node node = new Node(data);
            if (Head == null)
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
        public void DeleteFirstNode()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete");
            }

            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("Remove node is:" + temp.data);
        }

        public void DeleteLastNode()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Empty Linked List");
                return;
            }
            else
            {
                Node temp = this.Head;
                Node find = null;
                // Find second last node
                while (temp.next != null)
                {
                    find = temp;
                    temp = temp.next;
                }
                if (find == null)
                {
                    // Delete head node of linked list
                    this.Head = null;
                    this.Tail = null;
                }
                else
                {
                    // Set new last node
                    this.Tail = find;
                    find.next = null;
                    Console.WriteLine("Remove node is:" + temp.data);
                }
            }
        }
        public bool search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;

            }
            return false;
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
                Console.WriteLine("Linked List as follows");
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
