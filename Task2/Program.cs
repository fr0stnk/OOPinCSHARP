using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodsRepository goods = new GoodsRepository();
            goods.Goods = new Good[]
            {
                new Good()
                {
                    Name = "Test1",
                    Count = 2,
                    Price = 10
                },
                new Good()
                {
                    Name = "Test2",
                    Count = 3,
                    Price = 15
                },
                new Good()
                {
                    Name = "Test3",
                    Count = 2,
                    Price = 2
                }
            };
        }

        WendingMachine machine = new WendingMachine(1000, goods);
        WendingMachine machine2 = new WendingMachine(1000, goods);

        WendingMachineGUI gui = new WendingMachineGUI();
        gui.Machine = machine;
        while (true)
        {
            gui.Update();
        }

        public static Good MakeGood(int price, string name, int count)
        {
            Good good = new Good();
            good.Count = count;
            good.Name = name;
            good.Price = price;

            return good;
        }

    }
}
