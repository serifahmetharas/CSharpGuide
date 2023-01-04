using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Eventler bir delegedir. Delegates den faydalanmalıyız.

    public delegate void StockControl();
    class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock; // _stock değeri ile Stock değerini elde eder.
            }
            set // Stock değerinin durumuna göre bir ayarlama yapılabilir.
            {
                _stock = value; // kişinin verdiği değer anlamına gelir.
                if (value<=15 && StockControlEvent!=null) // 15ten düşük ve bu evente abone olmuşsa tetiklenir.
                {
                    StockControlEvent();
                     
                }     
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("Stock Amount: {0}", Stock);
        }
    }
}
