using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Good
    {
        public int Price;
        public string Name;
        public int Count;

        public bool IsAvialable()
        {
            return Count > 0;
        }
    }
}
