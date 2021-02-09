using ConsoleApp3;

namespace MyStackxD
{
    class MyStack
    {
        DynamicArray arr = new DynamicArray(1);
        
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
