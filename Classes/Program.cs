using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Methodlarımızı gruplama ve gruplara göre method çağırma imkanı sağlar.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            // Farklı sekmelerde property tutan classlar oluşturuldu.
            // Customer class ı sayesinde bir müşterinin Id,İsim,Soyisim ve Şehir propertylerine ulaşılabiliyor.

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Serif"; // Property tanımındaki set; kullanılır.
            customer.LastName = "Haras";
            customer.City = "Izmir";

            // Hem newleyip hem de değer verdiğin customer2 müşterimiz de şu şekilde girilir:
            Customer customer2 = new() { Id = 2, FirstName = "Afra", LastName = "Haras", City = "Izmir" };

            Console.WriteLine(customer2.FirstName); // Property tanımındaki get; kullanılır.

            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated.");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added.");
        }

        public void Update()
        {
            Console.WriteLine("Product updated.");
        }
    }
}
