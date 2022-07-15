using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;
using ctci.Contracts;

namespace LinkedLists
{
    internal class Palindrome : Question
    {
        public static bool isPalindrome(ListNode head)
        {
            var stack = new Stack<ListNode>();

            ListNode slow = head, fast = head;
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if (fast != null) slow = slow.Next;

            var reversed = Reverse(slow);

            while(reversed != null)
            {
                if(head.Data.ToString() != reversed.Data.ToString())
                {
                    return false;
                }
                reversed = reversed.Next;
                head = head.Next;
            }

            return true;
        }
        private static ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            while(head != null)
            {
                ListNode temp = head.Next;
                head.Next = prev;
                prev = head;
                head = temp;
            }
            return prev;
        }
        public override void Run()
        {
            var input = "aabbcbbaa";
            LinkedList list = new LinkedList();
            foreach (var n in input)
            {
                list.AddToLast(n);
            }

            Console.WriteLine("\nIs the list parlindrome?");
            Console.WriteLine("Original list: ");
            list.printAllNodes();
            Console.WriteLine(Palindrome.isPalindrome(list.head));
        }
    }
}
