using ConsoleApp3;

namespace Salavat.Queue
{
    class MyQueue
    {
        DynamicArray arr = new DynamicArray(10);

        public void Push(int n)
        {
            arr.PushBack(n);
        }

        public int Pop(int arrPointer)
        {
            return arr.Pop(arrPointer);
        }

        public void PrintMyQueue()
        {
            arr.printMassive();
        }

    }
}
