using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Order
    {
        public Good Good;
        public int Count;

        public int GetTotalPrice()
        {
            return Good.Price * Count;
        }

        //TODO: Rename
        public void ApplyOrder()
        {
            Good.Count -= Count;
        }
    }
}
