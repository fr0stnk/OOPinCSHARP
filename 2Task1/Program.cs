using System;

namespace Task1
{
    class Stack
    {
        private int[] Data = new int[1];
        private int Top  = -1;

        public void Push(int x)
        {
            if (Top + 1 >= Data.Length)
            {
                Array.Resize(ref Data, (Data.Length + 1) * 2);
            }

            Data[++Top] = x;
        }

        public int Pop()
        {
            if (Top == -1)
            {
                Console.WriteLine("Блинов не осталось");
                return -1;
            }


            Console.WriteLine("В блинчике " + Data[Top] + " каллорий");
            Top--;
            return 1;
        }

        public int GetSize()
        {
            return Data.Length;
        }

        public int[] GetData()
        {
            return Data;
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
                        pancakes.Pop();

                        break;

                    case "Испечь":
                        int calories = r.Next(1, 20);
                        Console.WriteLine($"Вы испекли блинчик с {calories} калориями");
                        pancakes.Push(calories);
                        break;

                    case "Покажи":
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
