﻿using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";
            
            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent; // Event i aktif et.
            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent() // StockControlEvent+= 2 tab ile bu yapıyı oluşturuyoruz.
        {
            Console.WriteLine("Gsm about to Finish!!!");
        }
    }

}
