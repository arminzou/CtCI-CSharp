using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class Partition
    {
        public static ListNode PartitionList(ListNode head, int x)
        {
            ListNode left = new ListNode(), right = new ListNode();
            ListNode p1 = left, p2 = right;
            ListNode p = head;

            while(p != null)
            {
                if((int)p.Data < x)
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
    }
}
