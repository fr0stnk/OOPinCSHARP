using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dialog> dialogs = new List<Dialog>();

            dialogs.Add(new Question("Кто вы?", Answer("Человек", "Брандлмуха", "Кхаджит")
            { }));
            dialogs.Add(new Dialog("Что вы хотите?", new string[]
                {"Победить Аразота", "Стать богатым", "Найти боевых товарищей"}));
            dialogs.Add(new Dialog("Чем вы можете помочь ордену?", new string[]
            { "Я отлчиный воин", "Я добротный маг", "Я могу работать в кузнице"}));

            Console.WriteLine("Совершенно очевидно, что мы не берём в наш орден \nкого попало. По этому заполни вот эту анкету, " +
                              "и мы \nпримем решение, брать тебя или нет...");
            Console.WriteLine();

            foreach (var item in dialogs )
            {
                item.DialogStart();
            }

            Console.ReadLine();
        }
    }
}
