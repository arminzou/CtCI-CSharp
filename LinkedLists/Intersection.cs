using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class Intersection
    {
        public static LinkedListNode FindIntersection(LinkedListNode list1, LinkedListNode list2)
        {
            if (list1 == null || list2 == null) return null;

            LinkedListNode p1 = list1;
            LinkedListNode p2 = list2;

            while (p1 != p2)
            {
                if (p1 == null)
                {
                    p1 = list2;
                }

                if (p2 == null)
                {
                    p2 = list1;
                }
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p1;
        }
    }
}
