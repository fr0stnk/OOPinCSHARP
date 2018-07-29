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
        public List<TaskList> TasksCollection = new List<TaskList>()
        {
                new TaskList("домашний"),
                new TaskList("рабочий"),
                new TaskList("семейный")
        };
        
        /// <summary>
        /// Create new task list
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            TasksCollection.Add(new TaskList(name.ToLower()));
        }
        
        /// <summary>
        /// Prints all tasks in the list: "name"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public void PrintTaskListsElements(string name)
        {
            Console.WriteLine(TasksCollection.FirstOrDefault(g => g.Name == name).Name);
            
        }

        
        public void PrintAllTasks()
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
