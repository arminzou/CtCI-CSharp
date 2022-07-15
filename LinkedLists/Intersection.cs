using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;
using ctci.Contracts;

namespace LinkedLists
{
    internal class Intersection : Question
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

        public override void Run()
        {
            int[] vals = { -1, -2, 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            LinkedListNode list1 = AssortedMethods.CreateLinkedListFromArray(vals);

            int[] vals2 = { 12, 14, 15 };
            LinkedListNode list2 = AssortedMethods.CreateLinkedListFromArray(vals2);

            list2.Next.Next = list1.Next.Next.Next.Next;

            Console.WriteLine("\nCheck if two lists has intersection");
            Console.WriteLine("List 1: ");
            Console.WriteLine(list1.PrintForward());
            Console.WriteLine("List 2: ");
            Console.WriteLine(list2.PrintForward());
            var result = Intersection.FindIntersection(list1, list2);
            Console.WriteLine("Intersection at: ");
            Console.WriteLine(result.Data.ToString());
        }
    }
}
