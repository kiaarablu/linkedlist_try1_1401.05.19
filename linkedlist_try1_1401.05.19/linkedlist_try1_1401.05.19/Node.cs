using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_try1_1401._05._19
{
    public class Node
    {
        public Node next { get; set; }
        public int value { get; set; }
    }
    public class Amaliat
    {
        Node firstnode = new Node();
        Node lastnode = new Node();

        public Amaliat()
        {
            firstnode.value = 1;
            firstnode.next = null;
            lastnode = firstnode;
        }
        public void Push(int val)
        {
            Node x = new Node();
            x.value = val;
            lastnode.next = x;
            lastnode = x;
        }
        public void print()
        {
            Node y = firstnode;
            while (y != null)
            {
                Console.WriteLine(y.value);
                y = y.next;
            }

        }


    }
}
