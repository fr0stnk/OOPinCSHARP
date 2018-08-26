using System;

namespace Task1
{
    class Stack
    {
        private int[] Data = new int[1];
        private int Top = 0;

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
                throw new InvalidOperationException("The stack is empty");

            int value = Data[--Top];
            Data[Top] = default(int);
            return value;
        }

        public int GetSize()
        {
            return Data.Length ;
        }

        public int[] GetData()
        {
            return Data;
        }

        public int GetCurrent()
        {
            if (Top == 0)
                return 0;
            return Data[Top];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack pancakes = new Stack();
            Random r = new Random();
            bool appRunFlag = true;

            while(appRunFlag)
            {
                Console.WriteLine("Что вы хотите?");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "Скушать":
                        if (pancakes.GetSize() != 0)
                        {
                            Console.WriteLine("В блинчике " + pancakes.GetCurrent() + " каллорий");
                            pancakes.Pop();
                        }
                        else Console.WriteLine("Сначала испеките блинчик!");

                        break;

                    case "Испечь":
                        int calories = r.Next(1, 20);
                        Console.WriteLine($"Вы испекли блинчик с {calories} калориями");
                        pancakes.Push(calories);
                        break;

                    case "Покажи все блины":
                        int[] array = pancakes.GetData();

                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine(array[i]);
                        }

                        break;

                    case "Выйти":
                        appRunFlag = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
