using ConsoleApp3;
using System;

namespace Salavat.Queue
{
    class MyQueue
    {
        public DynamicArray arr = new DynamicArray(1);
        private int GetArrPointer()
        {
            for (int i = 0; i < arr.numbers.Length; i++)
            {
                if (arr.numbers[i] != 0)
                {
                    return i;
                }
            }
            return 0;
        }

        public void Push(int n)
        {
            arr.PushBack(n);
        }

        public int Pop()
        {
            int arrPointer = GetArrPointer();
            return arr.Pop(arrPointer);
        }

        public void PrintMyQueue()
        {
            arr.printMassive();
        }

    }
}
