using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal static class StackExtension
    {
        public static void Sort(this Stack<int> stack)
        {
            var newStack = new Stack<int>();

            while(stack.Count > 0)
            {
                var temp = stack.Pop();
                while(newStack.Count > 0 && newStack.Peek() > temp)
                {
                    stack.Push(newStack.Pop());
                }
                newStack.Push(temp);
            }

            while(newStack.Count > 0)
            {
                stack.Push(newStack.Pop());
            }
        }

        public static Stack<int> MergeSort(this Stack<int> stack)
        {
            if (stack.Count <= 1) return stack;

            var left = new Stack<int>();
            var right = new Stack<int>();
            int count = 0;

            while(stack.Count != 0)
            {
                if (count % 2 == 0)
                    left.Push(stack.Pop());
                else
                    right.Push(stack.Pop());
                count++;
            }

            left = MergeSort(left);
            right = MergeSort(right);

            while(left.Count > 0 || right.Count > 0)
            {
                if (left.Count == 0)
                {
                    stack.Push(right.Pop());
                }
                else if(right.Count == 0)
                {
                    stack.Push(left.Pop());
                }
                else if(right.Peek() > left.Peek())
                {
                    stack.Push(left.Pop());
                }
                else if(right.Peek() <= left.Peek())
                {
                    stack.Push(right.Pop());
                }
            }

            var newStack = new Stack<int>();
            while (stack.Count > 0)
            {
                newStack.Push(stack.Pop());
            }
            return newStack;
        }
    }
}
