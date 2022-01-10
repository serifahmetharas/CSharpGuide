using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Serif", Age = 24 };
            CustomerDal customerDal = new CustomerDal();

            // customerDal.Add(customer);    AddNew kullanın uyarısı verecektir.
            customerDal.AddNew(customer); // çalışacaktır.

            Console.ReadLine();


        }
    }

    // Attribute lar ile nesnelerimizin property yada methodlarına anlamlar yükleyebiliriz. (ToTable, RequiredProperty gibi)

    [ToTable("Customers")] // Hata vermemesi için constructor uyguladık.
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }

    class CustomerDal
    {
        [Obsolete("Dont use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        // Bazı hazır Attribute lar da vardır. Mesela hazır Obsolette attribute ü ile bir methodu geçersiz kılıp diğer methoda yönlendirme sağlanabilir.
        // Mesela üstteki Add methodunda uyarı verir ve AddNew kullanmanı söyler.
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

    }

    // [AttributeUsage(AttributeTargets.All)] Her yere uygulanabilir.
    // [AttributeUsage(AttributeTargets.Class)] // Attribute sadece class lara eklenebilir. (Bir nevi attribute e attribute uyguladık.)
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false)] // Targets ile sadece property ler için kullanılmasını istiyoruz.
                                                                    // AllowMultiple ile o attribute ün birden fazla kullanımına izin verip verilmediğini belirtiyoruz.
    class RequiredPropertyAttribute : Attribute // Sonuna Attribute yazılır ve Attribute sınıfından inherit edilir.
    {


    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)] // Sadece class lara tablo olmasını istediğimiz için bu şekilde uyguladık.
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    // AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) şeklinde birden fazla Attribute Usage-Target kullanabiliriz.

    
    
}
