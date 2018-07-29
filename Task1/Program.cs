using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dialog> dialogs = new List<Dialog>();

            dialogs.Add(new Dialog(new Question("Кто вы?"), new List<Answer>
            {
                new Answer("Человек"),
                new Answer("Брандлмуха"),
                new Answer("Кхаджит")
            }));

            dialogs.Add(new Dialog(new Question("Что вы хотите?"), new List<Answer>
            {
                new Answer("Победить Аразота"),
                new Answer("Стать богатым"),
                new Answer("Найти боевых товарищей")
            }));

            dialogs.Add(new Dialog(new Question("Чем вы можете помочь ордену?"), new List<Answer>
            {
                new Answer("Я отличный воин"),
                new Answer("Я добротный маг"),
                new Answer("Я могу работать в кузнице")
            }));

            Console.WriteLine("Совершенно очевидно, что мы не берём в наш орден \nкого попало. По этому заполни вот эту анкету, " +
                              "и мы \nпримем решение, брать тебя или нет...");
            Console.WriteLine();
            foreach (var dialog in dialogs)
            {
                Console.WriteLine(dialog.Question.Text);

                foreach (var answer in dialog.AnswersList)
                {
                    Console.WriteLine($"{answer.Text} | ");
                }

                Console.WriteLine();
                Console.ReadLine();
                dialog.Door.SwitchState();
            }

            

            Console.ReadLine();
        }
    }
}
