using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract class lar tıpkı Interface ler gibi tek başına newlenemezler.

            Database database = new Oracle();
            database.Add();
            database.Delete();
                                                        // Görüldüğü gibi Add işlemleri aynıdır ancak Delete için farklı işlem yaparlar.
            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();
        
            // Inheritance özelliği gösterdiği için class a  ikinci bir Inheritance yazmak mümkün değildir.
        }
    }

    abstract class Database // İçerisine hem tamamlanmış hem de tamamlanmamış methodlar yazabiliyoruz.
    {
        public void Add()
        {
            Console.WriteLine("Added by default."); // Diyoruz ki ekleme tüm veritabanlarında aynıdır fakat;
        }

        public abstract void Delete(); // Silme işlemi tüm veri tabanlarında farklı.
    }

    class SqlServer : Database // Implement Abstract Class diyoruz. ve Override geliyor. Aslında abstract class içi dolu olmayan virtual methoddur.
                               // Farklı olan methodun diğer sınıflarda ayrı ayrı implement edilmesini sağlar.
    {
        public override void Delete() 
        {
            Console.WriteLine("Deleted by Sql.");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle.");
        }
    }
}
