using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class WendingMachine
    {
        public int Balance { get; private set; }

        private GoodsRepository _goods;

        public WendingMachine(int balance, GoodsRepository goods)
        {
            Balance = balance;
            _goods = goods;
        }

        public int ClearBalance()
        {
            int oldBalance = Balance;
            Balance = 0;
            return oldBalance;
        }

        public void ApplyOrder(Order order)
        {
            if (order == null) throw new ArgumentNullException("order", "");
            if (Balance < order.GetTotalPrice()) throw new InvalidOperationException("");

            Balance -= order.GetTotalPrice();
            order.ReduseAmount();
        }

        public Good[] GetProductList()
        {
            return _goods.GetAvialableGoods();
        }

        public Good GetProduct(string name)
        {
            return _goods.GetProduct(name);
        }
    }
}
