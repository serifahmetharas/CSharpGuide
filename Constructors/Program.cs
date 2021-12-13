using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // CustomerManager customerManager = new CustomerManager();   *Şeklinde newlediğinde parametresiz çalıştırıyorsun. 
            // İhtiyaç duyduğumuz parametreler olduğunda constructor kulanırız.

            CustomerManager customerManager = new CustomerManager(10); // Constructor kullandık ve List işlemi için gerekli parametreyi de girme imkanı sağladık.
            customerManager.List(); // dediğimizde List methodunun ihtiyaç duyduğu _count değerini elde eder ve "Listed 10 items olarak" çıktı alır.

            // Constructor ını overload edebilirsin.

            //*****İkinci Örnek*****

            Product product = new Product { Id = 1, Name = "Laptop" }; // Biz normalde class larımızın property lerini bu şekilde giriyoruz. 
            //Ama oluşturduğumuz Constructor sayesinde şu şekilde giriş sağlamak mümkün:
            Product product1 = new Product(2, "Tv");

            //*****Üçüncü Örnek*****

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger()); // Artık Interface ve Constructor sayesinde veritabanı ve dosya üzerine loglama yapmayı daha kolay bir şekilde seçiyoruz.
            employeeManager.Add(); // Ekleme işlemimizi yukarıdaki seçim sayesinde database e gerçekleştirdik. 

            //Base sınıfa parametre gönderme:

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            // Static Class kullanma

            Teacher.Number = 10; // Bu şekilde newlemeden ve direk property sini de alarak kullanabiliyoruz. Her yerden ulaşmak mümkündür.
                                 // Değiştiğinde her yerde değişsin istiyorsak bunu kullanabiliriz.


        }
    }

    class CustomerManager
    {
        // ctor+2tab ile constructor oluştur.
        int _count; // Her zaman _ ile başlatılır.                                     
        public CustomerManager(int count) // Methodda ise _ kullanılmaz.
        {
            _count = count;
        }


        public void List()
        {
            Console.WriteLine("Listed {0} items.", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added.");
        }
    }

    // Constructor kullanımına ikinci örnek:
    class Product
    {
        // 2 adet constructor tanımla.
        public Product()
        {

        }

        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Constructor kullanımına üçüncü örnek:
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger; // Hangi Logger? Database yada File almamızı sağlar.
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log(); // Alınan Logger a göre Log methodunu uygular.
            Console.WriteLine("Added.");
        }
    }

    // Base sınıfa parametre gönderme

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0}", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity) // base e entity değerini gönderdik.
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    // Static Class:
    // Newlenemezler.

    static class Teacher
    {
        public static int Number { get; set; } // Tanımladığımız property ler de static olmalıdır.
    }

    static class Utilities // Örneğin Utilities gibi sıklıkla kullanılan operasyonlar varsa böyle bir static class içinde kullanabiliriz.
    {
        public static void Validate() // Static olması gerektiğini unutmamak gerekiyor.
        {
            Console.WriteLine("Validation is done."); // İşini yap ve bitir tarzı şeylerde static olarak böyle methodlar oluşturabiliriz.
        }
    }

    // Class ın içindeki bir methodun static olma durumu:
    //DoSomething kullanacaksan classı newlemek zorunda değilsin. Ancak DoSomething2 kullanacaksan Manager class ını newlemek zorundasın.
    // Static bir sınıfın her şeyi static olmalıdır ancak class static değilse sadece bazı özelliklerinin static olması mümkün.
    class Manager
    {
        public static void DoSomething() // Static.
        {
            
        }

        public void DoSomething2() // Static değil.
        {

        }
    }
}

