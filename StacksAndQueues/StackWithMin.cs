using ctci.Contracts;
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
}
