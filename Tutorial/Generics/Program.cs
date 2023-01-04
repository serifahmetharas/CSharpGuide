using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Methodlar ile Generic kullanımı.
            Utilities utilities = new Utilities(); // Araçlar nesnesi gibi çeşitli işlemler yaptırdığımız bir class gibi düşün.
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            // Artık bu method sayesinde istediğimiz tipte istediğimiz listeyi oluşturabiliriz.
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Serif" }, new Customer { FirstName = "Afra" });

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)   // Farklı sınıflarla çalışacağımız için T olarak yazarız.
        {                                               // Listeyi hangi tür verirsek öyle döndürür.
            return new List<T>(items);
        }

    }

    // 2. Interface ler ile Generic kullanımı:

    // Product ve Customer classları, ikisi için de ProductDal ve CustomerDal interface leri oluşturulacak.
    // Daha fazla class eklenme ihtimaline ve sürekli yazma derdine çare olarak Generic nesne kullanıp,
    // IProductDal ve ICustomerDal için : IRepository<T> şeklinde ek bir interface kullanılabilir. (entity nesnesi kullanarak.)
    // Bu sayede ortak methodlar için IRepository<Product> veya IRepository<Customer> yazmak yeterli olur.
    // ProductDal veya ICustomerDal a özgü methodlar da var ise direk o interface in içine yazılabilir.

    class Product : IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {
        /*
         
        List<Product> GetAll(); // Liste döndüren GetAll methodu.
        Product Get(int id); // Sadece Product döndüren Get methodu.
        void Add(Product product); // Ürün ekleme işlemini yapan void bir method.

        void Delete(Product product); // Entity Framework gibi yapılarda bu şekilde nesne üzerinden gidilir.
                                      // Bir nesne veriyoruz ve bunu sil diyoruz.
        void Update(Product product);
        
         */

    }
    interface IEntity
    {

    }


    class Customer : IEntity
    {

        public string FirstName { get; set; }

    }

    interface ICustomerDal : IRepository<Customer>
    {
        void Custom(); // Bu şekilde özel methodlar da girmek mümkün.
    }

    interface IRepository<T> where T:class,IEntity,new() // where koşulu sayesinde <> içerisine sadece "referans tip" yazabilirsin. Kısıtlamış olduk.
                                                  // Ama string gibi referans tip değişkenleri de istemediğimizden new lenebilir olma koşulu koyduk.
        // Sadece veritabanı nesneleri yazılsın, Dal gibi nesneler yazılmasın istersek de,
        // Customer,Product gibi nesneleri IEntity diye bir interface implementasyonu içine alırız. Ve kısıtı IEntity olarak koyarız.
        // Referans tip için class, Value tip için Struct kısıtı konur.
        // UNUTMA!! new() kısıtı her zaman en sona konmalıdır.
      
        // T yerine product yada customer yazarak Dal işlemlerimizi gerçekleştirmemiz mümkün.
        // Customer ve product yerine de Entity gibi genel bir varlık kullanılır.
    {
        List<T> GetAll(); // Liste döndüren GetAll methodu.
        T Get(int id); // Sadece Product döndüren Get methodu.
        void Add(T entity); // Ürün ekleme işlemini yapan void bir method.

        void Delete(T entity); // Entity Framework gibi yapılarda bu şekilde nesne üzerinden gidilir.
                               // Bir nesne veriyoruz ve bunu sil diyoruz.
        void Update(T entity);

    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
