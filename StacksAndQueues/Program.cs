namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            Console.WriteLine(stack);
        }
    }
}