using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;
using ctci.Contracts;

namespace LinkedLists
{
    internal class DeleteMiddleNode : Question
    {
        public bool DeleteNode(ListNode node)
        {
            if(node == null || node.Next == null) {
                return false;
            }

            ListNode nextNode = node.Next;
            node.Data = nextNode.Data;
            node.Next = nextNode.Next;
            return true;
        }

        public override void Run()
        {
            var input = new int[] { 3, 3, 2, 2, 1, 0, 9, 1 };
            LinkedList list = new LinkedList();
            foreach (var n in input)
            {
                list.AddToLast(n);
            }

            Console.WriteLine("\nDelete 4th node giving access to the node");
            Console.WriteLine("Original list: ");
            list.printAllNodes();

            var node = list.head.Next.Next.Next;
            DeleteNode(node);
            Console.WriteLine("Result List:");
            list.printAllNodes();
        }
    }


}
