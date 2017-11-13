using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject02
{
    class TestSortedLinkedList
    {
        static void Main(string[] args)
        {
            SortedLinkedList<int> si = new SortedLinkedList<int>();
            si.Insert(8);
            si.PrintList();
            si.Insert(5);
            si.PrintList();
            si.Insert(20);
            si.PrintList();
            si.Insert(1);
            si.PrintList();
            si.Insert(17);
            si.PrintList();


            Console.WriteLine();
            SortedLinkedList<char> sc = new SortedLinkedList<char>();
            sc.Insert('K');
            sc.PrintList();
            sc.Insert('T');
            sc.PrintList();
            sc.Insert('Z');
            sc.PrintList();
            sc.Insert('M');
            sc.PrintList();
            sc.Insert('A');
            sc.PrintList();
        }
    }
}
