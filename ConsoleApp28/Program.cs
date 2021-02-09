using System;
using MyStackxD;
using Salavat.Queue;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray arr = new DynamicArray(10);
            arr.CreateRandomMassive();
            arr.printMassive();

            arr.ShakerSort();
            arr.printMassive();

            Console.WriteLine("Индекс найденного числа " + arr.BinarySearch(4));

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
            //MyStack two = new MyStack();
            //two.Push(500);
            //two.PrintMyStack();
            //
            //Console.WriteLine(two.Pop());
///////////////////////////////////////////////////////////////////////////////////////////////
            //MyQueue free = new MyQueue();
            //free.Push(220);
            //free.Push(220);
            //free.Push(300);
            //free.Pop();
            //free.PrintMyQueue();
            //
            //Console.WriteLine(free.Pop());
        }
    }

    public class DynamicArray
    {
        public int[] numbers { get; private set; }


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

        public object BinarySearch(int key)
        {
            int minNum = 0;
            int maxNum = numbers.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == numbers[mid])
                {
                    return mid;
                }
                else if (key < numbers[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return ("None");
        }

        //сортировка перемешиванием
        public void ShakerSort()
        {
            for (var i = 0; i < numbers.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = numbers.Length - 2 - i; j > i; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        Swap(ref numbers[j - 1], ref numbers[j]);
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }
        }

        public void BubbleSort()
        {
            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        private void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
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
