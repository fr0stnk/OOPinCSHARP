using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task
    {
        public string Text { get; set; }

        public Task(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
        
    }
}
