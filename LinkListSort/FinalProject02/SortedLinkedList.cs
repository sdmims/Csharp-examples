using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject02
{
    class SortedLinkedList<T> where T : IComparable<T>
    {
        private LinkedList<T> myList;

        public SortedLinkedList()
        {
            //new empty linked list
            myList = new LinkedList<T>();
        }

        public void PrintList()
        {
            //print each item in list
            Console.Write("Linked List: ");
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Insert(T newItem)
        {
            //no elements
            if (myList.Count == 0)
            {
                myList.AddFirst(newItem);
            }
            //one element
            else if (myList.Count == 1)
            {
                int n = newItem.CompareTo(myList.First.Value);
                //if less than or equal, add before
                if (n <= 0)
                {
                    myList.AddBefore(myList.First, newItem);
                }
                //if greater than, add after
                else
                {
                    myList.AddAfter(myList.First, newItem);
                }
            }
            //more than one element
            else
            {
                var node = myList.Last;
                int n = newItem.CompareTo(node.Value);
                if (n > 0)
                {
                    myList.AddAfter(node, newItem);
                }
                else
                {
                    var next = myList.First;
                    if(newItem.CompareTo(next.Value)<0)
                    {
                        myList.AddBefore(next, newItem);
                    }
                    else
                    {
                        while (next != null)
                        {
                            next = next.Next;
                            int m = newItem.CompareTo(next.Value);
                            if (m < 0)
                            {
                                myList.AddBefore(next, newItem);
                                break;
                            }
                        }
                   }
                    
                }
            }
        }
    }
}
