using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class TaskList : IEnumerable
    {
        public string Name { get; } //надо ли было создавить ещё и группу как объект?
        readonly List<Task> _tasks = new List<Task>();

        public TaskList(string name)
        {
            Name = name;
        }

        public void Add(string text)
        {
            _tasks.Add(new Task(text));
        }

        public IEnumerator GetEnumerator()
        {
            return _tasks.GetEnumerator();
        }
    }
}
