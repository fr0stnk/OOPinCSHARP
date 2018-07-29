using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class TaskManagerGUI
    {
        private TaskManager _taskManager;

        public TaskManagerGUI(TaskManager taskManager)
        {
            _taskManager = taskManager;
        }

        public void Update()
        {
            Console.Clear();

            Console.WriteLine("Доступные списки с задачами: ");
            _taskManager.PrintTaskLists();
            Console.WriteLine();
            Console.WriteLine("\nСписок доступных команд: AddTask, AddList, PrintTasks, PrintAllTasks, ClearTaskList");
            Console.WriteLine("Введите команду: ");

            string command = Console.ReadLine()?.ToLower();
            switch (command)
            {
                case "addtask":
                    Console.Write("Введите имя списка, в который нужно добавить новую задачу: ");
                    var listName = Console.ReadLine();
                    Console.Write("Введите текст задачи: ");
                    var taskText = Console.ReadLine();
                    _taskManager.AddTask(listName, taskText);
                    break;

                case "addlist":
                    Console.Write("Введите имя для нового списка: ");
                    var nameOfList = Console.ReadLine();
                    _taskManager.CreateTaskList(nameOfList);
                    break;

                case "printtasks":
                    Console.Write("Введите имя списка, задачи которого надо вывести: ");
                    var selectedList = Console.ReadLine();
                    _taskManager.PrintTaskListsElements(selectedList);
                    Console.ReadLine();
                    break;
                case "printalltasks":
                    Console.Write("Все задачи: ");
                    _taskManager.PrintAllTasks();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
