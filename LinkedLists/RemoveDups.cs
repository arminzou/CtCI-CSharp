using ctci.Library;
using ctci.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class RemoveDups : Question
    {
        public void DeleteDups(ListNode n)
        {
            var set = new HashSet<int>();
            ListNode prev = null;

            while (n != null)
            {
                if (set.Contains((int)n.Data))
                {
                    prev.Next = n.Next;
                }
                else
                {
                    set.Add((int)n.Data);
                    prev = n;
                }
                n = n.Next;
            }
        }

        public override void Run()
        {
            var input = new int[] { 3, 3, 2, 2, 1, 0, 9, 1 };
            LinkedList list = new LinkedList();
            foreach (var n in input)
            {
                list.AddToLast(n);
            }

            Console.WriteLine("\nRemove Duplicates");
            Console.WriteLine("Original list: ");
            list.printAllNodes();
            DeleteDups(list.head);
            Console.WriteLine("Result List:");
            list.printAllNodes();
        }
    }
}
