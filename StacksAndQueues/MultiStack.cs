using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class MultiStack
    {
        private int stackCapacity;
        private int[] stackValues;
        private int[] stackPointers;

        public MultiStack(int stackSize)
        {
            stackCapacity = stackSize;
            stackValues = new int[stackSize * 3];
            stackPointers = new int[3];
        }

        public void Push(int stackNum, int value)
        {
            if (stackPointers[stackNum] + 1 > stackCapacity) 
                throw new IndexOutOfRangeException("Out of space");
            stackPointers[stackNum]++;
            stackValues[IndexOfTop(stackNum)]= value;
        }

        public int Pop(int stackNum)
        {
            if (stackPointers[stackNum] == 0) throw new InvalidOperationException("Empty stack.");
            int topIndex = IndexOfTop(stackNum);
            int topValue = stackValues[topIndex];
            stackValues[topIndex] = 0;
            stackPointers[stackNum]--;
            return topValue;
        }

        public int Peek(int stackNum)
        {
            if (stackPointers[stackNum] == 0) throw new InvalidOperationException("Empty stack.");
            return stackValues[IndexOfTop(stackNum)];
        }

        private int IndexOfTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = stackPointers[stackNum];
            return offset + size - 1;
        }
    }
}
