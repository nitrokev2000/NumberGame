using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberView
{
    public class Node
    {
        public int Element;
        public Node Link;

        public Node()
        {
            Element = 0;
            Link = null;
        }

        public Node(int theElement)
        {
            Element = theElement;
            Link = null;
        }
    }

    public class LinkedList
    {
        protected Node header;

        public LinkedList()
        {
            header = new Node(-1);
        }

        private Node Find(int Item)
        {
            Node current = new Node();
            current = header;
            while (current.Element != Item)
            {
                current = current.Link;
            }
            return current;
        }

        public void InsertAfter(int newItem, int after)
        {
            Node current = new Node();
            Node newNode = new Node(newItem);
            current = Find(after);
            newNode.Link = current.Link;
            current.Link = newNode;
        }

        private Node FindPrevious(int n)
        {
            Node current = header;
            while (current.Link != null && current.Link.Element != n)
            {
                current = current.Link;
            }
            return current;
        }

        public void Remove(int n)
        {
            Node p = FindPrevious(n);
            if (p.Link != null)
            {
                p.Link = p.Link.Link;
            }
        }

        public void Insert(int Item)
        {
            Node current = new Node();
            Node newNode = new Node(Item);
            current = header;
            while (current.Link != null)
            {
                current = current.Link;
            }
            current.Link = newNode;
        }

        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (current.Link != null)
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }

        public void SortL()
        {
            Node current = new Node();
            Node next;

            int count = 0;
            Node LinkNode = new Node();
            LinkNode = header;
            //calculate the number of the link list node
            while (LinkNode.Link != null)
            {
                count++;
                LinkNode = LinkNode.Link;
            }
            //sort the linked list
            for (int i = 0; i < count; i++)
            {
                current = header;
                while (current.Link != null)
                {
                    next = new Node();
                    next = current.Link;

                    if (current.Element > next.Element)
                    {
                        int temp = current.Element;
                        current.Element = next.Element;
                        next.Element = temp;
                    }
                    current = current.Link;
                }
            }//end sort
        }
    }
}
