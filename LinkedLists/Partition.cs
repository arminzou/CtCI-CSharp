using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;
using ctci.Contracts;

namespace LinkedLists
{
    internal class Partition : Question
    {
        public ListNode PartitionList(ListNode head, int x)
        {
            ListNode left = new ListNode(), right = new ListNode();
            ListNode p1 = left, p2 = right;
            ListNode p = head;

            while (p != null)
            {
                if ((int)p.Data < x)
                {
                    p1.Next = p;
                    p1 = p1.Next;
                }
                else
                {
                    p2.Next = p;
                    p2 = p2.Next;
                }

                ListNode temp = p.Next;
                p.Next = null;
                p = temp;
            }

            p1.Next = right.Next;

            return left.Next;
        }
        public override void Run()
        {
            var input = new int[] { 3, 6, 8, 2, 0, 5, 1, 9, 5 };
            LinkedList list = new LinkedList();
            foreach (var n in input)
            {
                list.AddToLast(n);
            }

            Console.WriteLine("\nPartition the list with target = 5");
            Console.WriteLine("Original list: ");
            list.printAllNodes();

            var newList = PartitionList(list.head, 5);
            Console.WriteLine("Result list: ");
            LinkedList.printAllNodes(newList);
        }
    }
}
