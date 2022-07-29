using ctci.Contracts;
using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class NodeWithMin
    {
        public int Value { get; set; }
        public int Min { get; set; }
        public NodeWithMin(int value, int min)
        {
            Value = value;
            Min = min;
        }
    }

    internal class StackWithMin : MyStack<NodeWithMin>
    {
        public void Push2(int value)
        {
            var newMin = Math.Min(value, Min());
            Push(new NodeWithMin(value, newMin));
        }

        public int Min()
        {
            if (!this.isEmpty())
            {
                return Peek().Min;
            }
            else
            {
                return int.MaxValue;
            }
        }
    }

    internal class StackWithMin2 : Stack<int>
    {
        private readonly MyStack<int> s2;

        public StackWithMin2()
        {
            s2 = new MyStack<int>();
        }

        public void Push2(int value)
        {
            if (value <= Min())
            {
                s2.Push(value);
            }
            Push(value);
        }

        public int Pop2()
        {
            var value = Pop();
            if (value == Min())
            {
                s2.Pop();
            }
            return value;
        }

        public int Min()
        {
            if (!s2.isEmpty())
            {
                return s2.Peek();
            }
            else
            {
                return int.MaxValue;
            }
        }
    }

    public class Question_3_2
    {
        public void Run()
        {
            var stack = new StackWithMin();
            var stack2 = new StackWithMin2();

            for (var i = 1; i <= 10; i++)
            {
                var value = AssortedMethods.RandomIntInRange(0, 100);
                stack.Push2(value);
                stack2.Push2(value);
                Console.Write(value + ", ");
            }

            Console.WriteLine('\n');
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine("Popped " + stack.Pop().Value + ", " + stack2.Pop2());
                Console.WriteLine("New min is " + stack.Min() + ", " + stack2.Min());
            }
            Console.WriteLine("\n\n");
        }
    }
}
