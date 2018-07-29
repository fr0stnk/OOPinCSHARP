using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class TaskManager
    {
        //TODO: Не работает метод PrintTaskListElements
        public List<TaskList> TasksCollection = new List<TaskList>()
        {
                new TaskList("домашний"),
                new TaskList("рабочий"),
                new TaskList("семейный")
        };
        

        public void CreateTaskList(string name)
        {
            TasksCollection.Add(new TaskList(name.ToLower()));
        }
        

        public void PrintTaskListsElements(string name)
        {
            foreach (var listOfTasks in TasksCollection)
            {
                if (listOfTasks.Name != name)
                    Console.Write($"{listOfTasks} |");
            }
        }
        public void PrintTaskListsElements()
        {
            foreach (var listOfTasks in TasksCollection)
            {
                foreach (var task in listOfTasks)
                {
                    Console.Write($"{task} |");
                }
            }
        }

        public void PrintTaskLists()
        {
            foreach (var listOfTasks in TasksCollection)
            {
                Console.Write($"{listOfTasks.Name} |");
            }
        }

        public void AddTask(string nameOfCollection, string taskText)
        {
            foreach (var listOfTasks in TasksCollection)
            {
                if (listOfTasks.Name == nameOfCollection)
                {
                    listOfTasks.Add(taskText);
                }
            }
        }
    }
}
