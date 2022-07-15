using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class DeleteMiddleNode
    {
        public static bool DeleteNode(ListNode node)
        {
            if(node == null || node.Next == null) {
                return false;
            }

            ListNode nextNode = node.Next;
            node.Data = nextNode.Data;
            node.Next = nextNode.Next;
            return true;
        }
    }


}
