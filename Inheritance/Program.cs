using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            // customer.FirstName diyebilirsin çünkü Customer bir Person dır.

            /*
              Person[] persons = new Person[3]
            {
                new Customer(), new Student(), new Person() 
            } // Bu şekilde Customer ve Student ı Person olarak newleyebilirsin.
              // Person da newlenebilir çünkü Inheritance da tek başına da anlam içerebilir. Genel bir insan tanımı yani. (Interface den en büyük farkı budur.)
       
            */

            // Mesela Person newleyerek Custome,Student ve Person classlarını tanımlayabilirsin.

            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Serif"}, new Student{FirstName="Afra"},new Person{FirstName="Ali"}
            }; // Hepsinin FirstName lerini oluşturduk.

            foreach (var person in persons) // Persons dizisinde Person larımızda dolaşarak FirstName leri döndürerek yazdıralım.
            {
                Console.WriteLine(person.FirstName);
            }

            // **Önemli**
            // Bir class ta bir kere inheritance yapabilirsin. (Inheritance ı baba gibi düşünürsek, bir class ın iki farklı babası olamaz gibi düşünülebilir.) 
            // Interface den farkı tek başına anlam içermesi ve class bloklarında Interface gibi yeniden implementasyon yapmamız gerekmemesidir.
            // Abstract Sınıflarla çalışırken önem arz eder.
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Customer : Person // Customer ın ebeveyni Person dır.
        {
            public string City { get; set; } // Customer a has özellikler olabilir.
        }

        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
