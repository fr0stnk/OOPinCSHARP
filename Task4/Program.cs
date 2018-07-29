using System;
using System.Threading;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var taskManager = new TaskManagerGUI(new TaskManager());
                while (true)
                {
                    taskManager.Update();
                }
            }
        }

    }
}
