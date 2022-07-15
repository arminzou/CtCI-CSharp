using ctci.Library;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Remove Duplicates
            RemoveDups removeDups = new RemoveDups();
            removeDups.Run();

            // Return Kth to last
            ReturnKthToLast returnKthToLast = new ReturnKthToLast();
            returnKthToLast.Run();

            // Delete Middle Node giving only access to the node
            DeleteMiddleNode deleteMiddleNode = new DeleteMiddleNode();
            deleteMiddleNode.Run();

            // Partition
            Partition partition = new Partition();
            partition.Run();


            // Sum of two lists
            SumLists sumLists = new SumLists();
            sumLists.Run();


            // Palindrome
            Palindrome palindrome = new Palindrome();
            palindrome.Run();


            // Intersection
            Intersection intersection = new Intersection();
            intersection.Run();

            // loop detection
            LoopDetection detection = new LoopDetection();
            detection.Run();
        }
    }
}