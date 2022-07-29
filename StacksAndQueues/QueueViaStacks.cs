using ctci.Contracts;
using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    // Implement a MyQueue class which implements a queue using two stacks
    // stack1  |  stack2
    // enqueue to stack1  1  2  3  4 -> 4 3 2 
    // enqueue 5 to stack 1 -> stack1 = 5  stack2 = 4 3 2
    // dequeue stack2.push(stack1.pop())

    public class StackQueue<T>
    {
        Stack<T> stack1, stack2;

        public StackQueue()
        {
            stack1 = new Stack<T>();
            stack2 = new Stack<T>();
        }

        public int Size()
        {
            return stack1.Count + stack2.Count;
        }

        public void Enqueue(T value)
        {
            stack1.Push(value);
        }

        public T Dequeue()
        {
            ShiftStacks();
            return stack2.Pop();

        }

        public T Peek()
        {
            ShiftStacks();
            return stack2.Peek();
        }

        public void ShiftStacks()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
        }
    }

    public class Question_3_4
    {
        public void Run()
        {
            var myQueue = new StackQueue<int>();

            // Let's test our code against a "real" queue
            var testQueue = new Queue<int>();

            for (var i = 0; i < 100; i++)
            {
                var choice = AssortedMethods.RandomIntInRange(0, 10);

                if (choice <= 5)
                {
                    // enqueue
                    var element = AssortedMethods.RandomIntInRange(1, 10);
                    testQueue.Enqueue(element);
                    myQueue.Enqueue(element);
                    Console.WriteLine("Enqueued " + element);
                }
                else if (testQueue.Count > 0)
                {
                    var top1 = testQueue.Dequeue();
                    var top2 = myQueue.Dequeue();

                    if (top1 != top2)
                    { // Check for error
                        Console.WriteLine("******* FAILURE - DIFFERENT TOPS: " + top1 + ", " + top2);
                    }
                    Console.WriteLine("Dequeued " + top1);
                }

                if (testQueue.Count == myQueue.Size())
                {
                    if (testQueue.Count > 0 && testQueue.Peek() != myQueue.Peek())
                    {
                        Console.WriteLine("******* FAILURE - DIFFERENT TOPS: " + testQueue.Peek() + ", " + myQueue.Peek() + " ******");
                    }
                }
                else
                {
                    Console.WriteLine("******* FAILURE - DIFFERENT SIZES ******");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
