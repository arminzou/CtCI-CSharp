using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;
using ctci.Contracts;

namespace LinkedLists
{
    internal class LoopDetection : Question
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

        public override void Run()
        {
            const int listLength = 10;
            const int k = 3;

            // Create linked list
            var nodes = new LinkedListNode[listLength];
            Console.WriteLine("\nFind the start point of the loop");

            for (var i = 1; i <= listLength; i++)
            {
                nodes[i - 1] = new LinkedListNode(i, null, i - 1 > 0 ? nodes[i - 2] : null);
                Console.Write("{0} -> ", nodes[i - 1].Data);
            }

            // Create loop;
            nodes[listLength - 1].Next = nodes[listLength - k - 1];
            Console.WriteLine("{0} -> {1}", nodes[listLength - 1].Data, nodes[listLength - k - 1].Data);
            var loop = LoopDetection.FindBeginning(nodes[0]);
            if (loop == null)
            {
                Console.WriteLine("No Cycle.");
            }
            else
            {
                Console.WriteLine(loop.Data.ToString());
            }
        }
    }
}
