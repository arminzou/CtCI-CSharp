using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class SumLists
    {
        // Time: O(n) Space:O(1)
        public static ListNode AddLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode p = result;
            int carry = 0;

            while (list1 != null || list2 != null || carry > 0)
            {
                int first = list1 == null ? 0 : (int)list1.Data;
                int second = list2 == null ? 0 : (int)list2.Data;
                int sum = first + second + carry;
                carry = sum / 10;
                int digit = sum % 10;

                p.Next = new ListNode(digit);
                p = p.Next;

                if (list1 != null) list1 = list1.Next;
                if (list2 != null) list2 = list2.Next;
            }

            return result.Next;
        }

        // Time: O(n) Space: O(1)
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;

            ListNode p = head, prev = null;

            while(p != null)
            {
                ListNode temp = p.Next;
                p.Next = prev;
                prev = p;
                p = temp;
            }

            return prev;
        }
    }
}
