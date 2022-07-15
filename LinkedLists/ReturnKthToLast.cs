using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;

namespace LinkedLists
{
    internal class ReturnKthToLast
    {
        public static object KthToLast(ListNode head, int n)
        {
            ListNode dummy = new ListNode();
            dummy.Next = head;

            var prev = FindNode(dummy, n+1);

            return prev.Next.Data;
        }

        private static ListNode FindNode(ListNode dummy, int n)
        {
            ListNode p1 = dummy, p2 = dummy;
            for(int i = 0; i < n; i++)
            {
                p1 = p1.Next;
            }

            while(p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p2;
        }
    }
}
