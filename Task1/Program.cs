using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace OOPinCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dialog> dialogs = new List<Dialog>();

            dialogs.Add(new Dialog("Кто вы?", new[]
                { "Человек", "Брандлмуха", "Кхаджит" }));
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

       class Dialog
        {
            #region Fields
            private string Question { get; }
            private string[] Answers { get; }
            public bool IsDoorOpen { get; set; }
            
            #endregion
            
            #region Constructor
            public Dialog(string question, string[] answers)
            {
                Question = question;
                Answers = answers;
            }
            #endregion

            #region Methods
            public void DialogStart()
            {
                Console.WriteLine(Question);
                WriteAnswers();
                Console.ReadLine();
                Console.WriteLine();
                IsDoorOpen = true;
            }

            private void WriteAnswers()
            {
                foreach (var item in Answers)
                {
                    Console.WriteLine($"{item}");
                }
            }
            #endregion


        }
    }
}
