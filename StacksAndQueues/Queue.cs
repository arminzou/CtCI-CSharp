using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class QueueNode<T>
    {
        internal T Data;
        internal QueueNode<T> Next;
        public QueueNode(T data)
        {
            Data = data;
        }
    }

    internal class MyQueue<T>
    {
        internal QueueNode<T> First;
        internal QueueNode<T> Last;

        public void Enqueue(T item)
        {
            var node = new QueueNode<T>(item);
            if (Last == null)
            {
                First = node;
            }
            else
            {
                Last.Next = node;
            }
            Last = node;
        }

        public T Dequeue()
        {
            if (First == null) throw new InvalidOperationException();
            var data = First.Data;
            First = First.Next;
            if (First == null)
            {
                Last = null;
            }
            return data;
        }

        public T Peek()
        {
            if (First == null) throw new InvalidOperationException();
            return First.Data;
        }

        public bool IsEmpty()
        {
            return First == null;
        }
    }
}
