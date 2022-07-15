using ctci.Library;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var input1 = new int[] { 6, 1, 7 };
            //var input2 = new int[] { 2, 9, 5 };
            //string input = "abcbba";
            //LinkedList list1 = new LinkedList();
            //LinkedList list2 = new LinkedList();
            //foreach (var n in input)
            //{
            //    list1.AddToLast(n);
            //}

            //foreach (var n in input2)
            //{
            //    list2.AddToLast(n);
            //}

            //list1.printAllNodes();
            //list2.printAllNodes();
            // Remove Duplicates
            //RemoveDups.DeleteDups(list.head);
            //list.printAllNodes();

            // Return Kth to last
            //Console.WriteLine(ReturnKthToLast.KthToLast(list.head, 2));


            // Delete Middle Node giving only access to the node
            //DeleteMiddleNode.DeleteNode(list.head.Next);
            //list.printAllNodes();

            // Partition
            //var newList = Partition.PartitionList(list.head, 5);
            //LinkedList.printAllNodes(newList);

            // Sum of two lists
            //var result = SumLists.AddLists(list1.head, list2.head);
            //LinkedList.printAllNodes(result);
            //var reversed = SumLists.ReverseList(result);
            //LinkedList.printAllNodes(reversed);

            // Palindrome
            //Console.WriteLine(Palindrome.isPalindrome(list1.head));

            // Intersection
            //int[] vals = { -1, -2, 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            //LinkedListNode list1 = AssortedMethods.CreateLinkedListFromArray(vals);

            //int[] vals2 = { 12, 14, 15 };
            //LinkedListNode list2 = AssortedMethods.CreateLinkedListFromArray(vals2);

            //list2.Next.Next = list1.Next.Next.Next.Next;

            //Console.WriteLine(list1.PrintForward());
            //Console.WriteLine(list2.PrintForward());
            //var result = Intersection.FindIntersection(list1, list2);
            //Console.WriteLine(result);

            // loop detection
            const int listLength = 10;
            const int k = 3;

            // Create linked list
            var nodes = new LinkedListNode[listLength];

            for (var i = 1; i <= listLength; i++)
            {
                nodes[i - 1] = new LinkedListNode(i, null, i - 1 > 0 ? nodes[i - 2] : null);
                Console.Write("{0} -> ", nodes[i - 1].Data);
            }
            Console.WriteLine();

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
                Console.WriteLine(loop.Data);
            }
        }
    }

}