using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;
using ctci.Contracts;

namespace LinkedLists
{
    internal class ReturnKthToLast : Question
    {
        public object KthToLast(ListNode head, int n)
        {
            ListNode dummy = new ListNode();
            dummy.Next = head;

            var prev = FindNode(dummy, n + 1);

            return prev.Next.Data;
        }

        private ListNode FindNode(ListNode dummy, int n)
        {
            ListNode p1 = dummy, p2 = dummy;
            for (int i = 0; i < n; i++)
            {
                p1 = p1.Next;
            }

            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p2;
        }

        public override void Run()
        {
            var input = new int[] { 3, 3, 2, 2, 1, 0, 9, 1 };
            LinkedList list = new LinkedList();
            foreach (var n in input)
            {
                list.AddToLast(n);
            }

            Console.WriteLine("\nReturn Kth Node");
            Console.WriteLine("Original list: ");
            list.printAllNodes();
            Console.WriteLine($"Kth node: {KthToLast(list.head, 2)}");
        }
    }
}
