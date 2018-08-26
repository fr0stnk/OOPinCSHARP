using System;

namespace Task1
{
    class Stack
    {
        private int[] Data = new int[1];
        private int Top = -1;

        public void Push(int x)
        {
            if (Top + 1 >= Data.Length)
            {
                //Notice the + 1, to counter the 0 length problem
                Array.Resize(ref Data, (Data.Length + 1) * 2);
            }

            Data[Top++] = x;
        }

        public int Pop()
        {
            if (Top == 0)
                Console.WriteLine("Сначала надо испечь блинчик!");

            int value = Data[--Top];
            Data[Top] = default(int);
            return value;
        }

        public int GetSize()
        {
            return Data.Length;
        }

        public int[] GetData()
        {
            return Data;
        }

        public int GetCurrent()
        {
            return Data[Top];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack pancakes = new Stack();
            Random r = new Random();

            Console.WriteLine("Что вы хотите?");
            string command = Console.ReadLine();
            switch (command)
            {
                case "Скушать":
                    Console.WriteLine($"В блинчике {pancakes.GetCurrent()} каллорий");
                    break;

                case "Испечь":
                    int calories = r.Next(1, 20);
                    Console.WriteLine($"Вы испекли блинчик с ${calories} калориями");
                    pancakes.Push(calories);
                    break;

                default:
                    break;
            }
        }
    }
}
