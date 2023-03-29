using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListObjects
{
    class Node
    {
        public char value;
        public Node next; // the pointer
        public Node(char value, Node next)
        {
            this.value = value;
            this.next = next;
        }

        public Node(char value)
        {
            this.value = value;
            next = null;
        }

        public Node()
        {
            value = '!'; // placeholder character / null
            next = null;
        }
    }

    class ObjectList
    {
        public Node start = null;

        public Node getNode(char data)
        {
            return findItem(data); // returns null if not found;
        }

        public bool Append(Node item)
        {
            Node final = findItem(null);
            if (final == null)
            {
                start = item;
            }
            else
            {
                final.next = start;
            }
            return false;
        }

        public bool Insert(Node item, Node position)
        {
            findItem(position.value);
            return false;
        }

        public Node Delete(char data)
        {
            Node beforeDelete = findItem(findItem(data));
            beforeDelete.next = beforeDelete.next.next;
            return new Node();
        }

        private Node findItem(char data)
        {
            Node current = start;

            while (current != null)
            {
                if (current.value == data)
                {
                    return current; // found
                }
                else
                {
                    current = current.next;
                }
            }
            return null; // not found
        }

        private Node findItem(Node location)
        {
            Node current = start;

            while (current != null)
            {
                if (current.next == location)
                {
                    return current; // found
                }
                else
                {
                    current = current.next;
                }
            }
            return null; // not found
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ObjectList ourList = new ObjectList();
            Node a = new Node('a');
            Node b = new Node('b');
            ourList.Append(a);
            ourList.Append(b);
        }
    }
}
