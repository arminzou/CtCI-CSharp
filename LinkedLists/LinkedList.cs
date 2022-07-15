using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class ListNode
    {
        public object Data;
        public ListNode Next;
        public ListNode(object data = null, ListNode next = null)
        {
            this.Data = data;
            this.Next = next;
        }
    }

    internal class LinkedList
    {
        public ListNode head;

        public void AddToLast(Object data)
        {
            if (head == null)
            {
                head = new ListNode(data);
            }
            else
            {
                ListNode toAdd = new ListNode();
                toAdd.Data = data;
                ListNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }
        }
        public void printAllNodes()
        {
            ListNode current = head;
            StringBuilder sb = new StringBuilder();
            while (current != null)
            {
                sb.Append(current.Data + "->");
                current = current.Next;
            }
            sb.Append("null");
            Console.WriteLine(sb);
        }

        public static void printAllNodes(ListNode head)
        {
            ListNode current = head;
            StringBuilder sb = new StringBuilder();
            while (current != null)
            {
                sb.Append(current.Data + "->");
                current = current.Next;
            }
            sb.Append("null");
            Console.WriteLine(sb);
        }
    }
}
