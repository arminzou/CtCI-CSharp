using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;

namespace LinkedLists
{
    internal class LoopDetection
    {
        public static LinkedListNode FindBeginning(LinkedListNode head)
        {
            LinkedListNode slow = head, fast = head;

            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast) break;
            }

            if (fast == null || fast.Next == null) return null;

            fast = head;
            while(slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow;
        }
    }
}
