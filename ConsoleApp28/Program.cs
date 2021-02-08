using System;
using MyStackxD;
using Salavat.Queue;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DynamicArray arr = new DynamicArray(10);
            //arr.CreateRandomMassive();
            //arr.printMassive();
            //
            //Console.WriteLine(arr.Pop(0));
            //arr.printMassive();
            //
            //arr.PushBack(12);
            //arr.printMassive();
            //
            //arr.Insert(8, 44);
            //arr.printMassive();
            //
            //arr.Delete(8);
            //arr.printMassive();

/////////////////////////////////////////////////////////////////////////////////////////////
            MyStack two = new MyStack();
            two.Push(500);
            two.PrintMyStack();

            Console.WriteLine(two.Pop());
/////////////////////////////////////////////////////////////////////////////////////////////
            MyQueue free = new MyQueue();
            free.Push(220);
            free.Push(220);
            free.Pop(0);
            free.PrintMyQueue();

            Console.WriteLine(free.Pop(0));
        }
    }

    public class DynamicArray
    {
        public int[] numbers { get; set; }

        public DynamicArray(int n)
        {
            numbers = new int[n];
        }

        public void CreateRandomMassive()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next(0, 10 + 1);
                numbers[i] = value;
            }
        }

        public void PushBack(int n)
        {
            int DelNumber = numbers[numbers.Length - 1];
            int[] temp = new int[numbers.Length + 1];
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = numbers[i];
            }
            temp[temp.Length - 1] = n;
            numbers = temp;

        }

        public int Pop()
        {
            int DelNumber = numbers[numbers.Length - 1];
            int[] temp = new int[numbers.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = numbers[i];
            }
            numbers = temp;
            return DelNumber;
        }

        public int Pop(int arrPointer)
        {

            int DelNumber = numbers[arrPointer];
            int[] temp = new int[numbers.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = numbers[i+1];
            }
            numbers = temp;
            return DelNumber;
        }

        public void Insert(int NumInd, int n)
        {

            int[] temp = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                temp[i] = numbers[i];
            }
            for (int i = temp.Length - 1; i > NumInd; i--)
            {
                var tempe = temp[i];
                temp[i] = temp[i - 1];
                temp[i - 1] = tempe;
            }
            temp[NumInd] = n;
            numbers = temp;
        }

        public void Delete(int NumInd)
        {
            int[] temp = new int[numbers.Length - 1];
            for (int i = 0; i < NumInd; i++)
            {
                temp[i] = numbers[i];
            }
            for (int i = NumInd + 1; i < numbers.Length; i++)
            {
                temp[i - 1] = numbers[i];
            }
            numbers = temp;

        }

        public void printMassive()
        {

            foreach (var i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

    }
}
