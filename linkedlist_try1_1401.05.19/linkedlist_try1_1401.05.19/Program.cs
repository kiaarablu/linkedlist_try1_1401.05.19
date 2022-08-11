using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_try1_1401._05._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Amaliat x = new Amaliat();
            if (a == "s")
            {
                x.Push(10);
                x.Push(11);
                x.Push(12);
                x.Push(13);
                x.Push(14);
                x.Push(15);
                x.Push(16);
                x.Push(17);
                x.Push(18);
                x.Push(19);
                x.Push(20);
                x.Push(21);
                x.Push(22);
                x.Push(23);
                x.Push(24);
                x.Push(25);
                x.Push(26);
                x.Push(27);
                x.print();
            }
            else
            {
                Console.WriteLine("password not found...!");
            }

            Console.ReadKey();
        }
    }
}
