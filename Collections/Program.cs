using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();

            // List();

            // Dictionary();

            Console.ReadLine();

        }

        private static void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // <Tkey,TValue> şeklinde anahtar-değer prensibiyle çalışır. İçeriye anahtar ve değerin türleri yazılır. 
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar"); // şeklinde kullanımı vardır.

            Console.WriteLine(dictionary["book"]); // Şeklinde indisi Key olacak şekilde Key-Value prensibiyle çalıştırırız.

            foreach (var item in dictionary)
            {
                Console.WriteLine(item); // [book,kitap] olarak çıktı verir.
                Console.WriteLine(item.Key); // book olarak çıktı verir.
                Console.WriteLine(item.Value); // kitap olarak çıktı verir.
            }

            /* ArrayList ve List te bulunan methodları aynen kullanabiliriz. Buna özgü methodlar ise:
            
            dictionary.ContainsKey("glass"); // Key ler arasında arama yapılmasını sağlar.
            dictionary.ContainsValue("tablo"); // Value lar arasında arama yapılmasını sağlar.
             
             */
        }

        private static void List()
        {
            List<string> cities = new List<string>(); // Typesafe bir koleksiyondur. List<T>
            cities.Add("Ankara"); // Mutlaka String ister.
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>(); // Bir Customer class ı oluşturarak, Customer tipinde bir List oluşturup, çeşitli çalışmalar yapmak mümkündür.
            customers.Add(new Customer { Id = 1, FirstName = "Serif", LastName = "Haras" });
            customers.Add(new Customer { Id = 2, FirstName = "Afra", LastName = "Ildes" });

            // Yada List<Customer> tanımlama için bir diğer yazım şekli aşağıdaki gibidir.

            List<Customer> customers1 = new List<Customer>
            {
                new Customer{Id = 1, FirstName = "Serif", LastName = "Haras"},
                new Customer{Id = 2, FirstName = "Afra", LastName = "Ildes"}
            };


            foreach (var customer in customers) // Bu şekilde Customer ların List indeki nesnelerimizi yazdırabiliriz.
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
            }

            /*  Bazı List methodları.
            customers.Add(); // Eleman ekler, Customer türünde girmelisin.
            customers.Count(); // Eleman sayısını verir.
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=3,FirstName="Ozlem",LastName="Haras"},
                new Customer{Id=4,FirstName="Rukiye",LastName="Cilli"}
            }); // Array şeklinde birden çok eleman ekleyebilirsin. Bu örnek için Customer türünde bir array olmalıydı.
            
            customers.Contains(); // Girilen elemanı içerip içermediğini sorgular.
            customers.IndexOf(); // Girilen elemanın kaçıncı sırada olduğunu sorgular.
            customers.LastIndexOf; // Girilen elemanın kaçıncı sırada olduğunu sorgular ancak sorgulamaya sondan başlar.
            customers.Insert(); // Kaçıncı elemana hangi elemanı girmek istediğimizi (2,customer2) şeklinde girebiliriz.
            customers.Remove(); // Eleman kaldırma. Birden fazla o eleman mevcutsa ilk bulduğunu kaldırır ve durur.
            customers.RemoveAll(); // Listede girilen eleman kaç tane varsa hepsini kaldırır. (c=>c.FirstName=="Serif"); şeklinde bir kullanımı vardır.

            customers.Clear(); // Tüm List i temizler.  
            */
        }

        private static void ArrayList()
        {
            /* 
             
            string[] cities = new string[2] { "Ankara", "İstanbul" };
            cities[2] = "Adana"; dersen hata alırsın çünkü cities string 2 elemanlı. 0. ve 1. indis var ancak 2. indisi yok.
            cities = new string[3]; 3 elemanlı hale getirmek için yeniden newlemen gerekir.
            Console.WriteLine(cities[0]); Ankara vermesini beklersin ancak vermez, çünkü boyutunu büyütmek için aslında yeniden oluşturmuş yani newlemişsindir.
            Bu sorunu ortadan kaldırmak için koleksiyonlara ihtiyaç duyarız.
            
            */

            ArrayList cities = new ArrayList(); // Using System.Collections ile ArrayList Collection oluşturuyoruz.
            cities.Add("Ankara"); // Ekleme, çıkarma gibi çeşitli işlemleri yapabilmemizi ve array bazlı dinamik şekilde çalışabilmemizi sağlayan methodları içerir.
            cities.Add("Adana");

            Console.WriteLine(cities[1]); // Array bazlı olduğu için indislerle çalışmak mümkündür.

            cities.Add(1); // Object türünde giriş ister, zaten tüm türlerin de temeli objecttir. Hepsini kullanabiliriz. Typesafe olmayan bir projede kullanılabilir. (Ancak ilk amaç her zaman typesafe kullanmak olmalıdır.)
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }

    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
