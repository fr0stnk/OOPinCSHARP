using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class WendingMachineGUI
    {
        public WendingMachine Machine;

        public void Update()
        {
            Console.Clear();
            Console.WriteLine($"Balance - {Machine.Balance}");
            Console.WriteLine();

            Console.WriteLine("For command list, write 'help' \nWrite command... ");

            string command = Console.ReadLine();
            switch (command)
            {
                case "help":
                    Console.WriteLine("list\norder\n");
                    break;
                case "list":
                    foreach (Good good in Machine.GetProductList())
                    {
                        Console.WriteLine($">{good.Name} [{good.Count}]");
                    }
                    break;
                case "order":
                    Console.WriteLine("имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("кол-во");
                    int count = Convert.ToInt32(Console.ReadLine());

                    Order order = new Order();
                    order.Good = Machine.GetProduct(name);
                    order.Count = count;

                    Console.WriteLine($"Общая сума - {order.GetTotalPrice()}");

                    Machine.ApplyOrder(order);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
