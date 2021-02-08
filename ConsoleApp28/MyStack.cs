using ConsoleApp3;

namespace MyStackxD
{
    class MyStack
    {
        DynamicArray arr = new DynamicArray(10);
        
        public void Push(int n)
        {
            arr.PushBack(n);
        }

        public void PrintMyStack()
        {
            arr.printMassive();
        }

        public int Pop()
        {
            return arr.Pop();
        }
    }
}
