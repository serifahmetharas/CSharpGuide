using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ana blokta PersonManager classını çağırıp içinde tanımlı methodun uygulanmasını sağlayalım.
            PersonManager manager = new PersonManager(); // Class ı newledik.
            manager.Add(new Customer { Id = 1, FirstName = "Serif", LastName = "Haras", Address = "Izmir" }); // Methodu kullandık.
                                                                                                              //Görüldüğü gibi methodun içinde Customer sınıfını newleyerek yeni bir müşteri oluşturup methodu öyle çalıştırdık.

            //Aynı işlemi student için de yaptıralım.
            //Methodu Student classı ile de kullanabilirsin, çünkü PersonManager classı içinde methodun IPersonlar ile çalışabildiğini yazdık.
            manager.Add(new Student { Id = 2, FirstName = "Afra", LastName = "Ildes", Department = "Engineering" });

            // Hem Customer hem Student birer IPerson olduğu için PersonManager classındaki Add methodunu ikisi için de kullanabiliriz.
            // İleride Worker gibi yeni bir class oluşturduğumuzda onu da IPerson yaparsak, methodu onun için de kullanabiliriz.
        }

    }

    interface IPerson // Her zaman I ile başlamalı. 
    {                 // Class somut, interface ise soyut nesnedir.

        int Id { get; set; } // prop+2tab ile propertyler oluşturulur.
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson // Sen bir IPerson sın.
    {                        // Class oluşturdun. IPerson olduğunu yazdın, O zaman bu Interface i burada da implement etmen gerekiyor.
                             // Interface in public hali olarak implement edilir.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } // Bu şekilde yada VS yardımıyla direk implement et tuşuna basarak da yapabiliriz.

        // Bu class ın bir IPerson olduğunu söyleyip o propertyleri implement ettik. Ayrıca kendine has ek property tutuyorsa onlar da eklenir.
        public string Address { get; set; }
    }

    class Student : IPerson // Sen de bir IPerson sın.
    {
        // IPerson için implementasyon:
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Student classına has diğer propertyler:
        public string Department { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
