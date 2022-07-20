using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class StackNode<T>
    {
        internal T Data;
        internal StackNode<T> Next;

        public StackNode(T data)
        {
            Data = data;
        }
    }

    internal class MyStack<T>
    {
        private StackNode<T> Top;

        public T Pop()
        {
            if (Top == null) throw new InvalidOperationException();
            T item = Top.Data;
            Top = Top.Next;
            return item;
        }

        public void Push(T item)
        {
            StackNode<T> StackNode = new StackNode<T>(item);
            StackNode.Next = Top;
            Top = StackNode;
        }

        public T Peek()
        {
            if (Top == null) throw new InvalidOperationException();
            return Top.Data;
        }

        public bool isEmpty()
        {
            return Top == null;
        }
    }

}
