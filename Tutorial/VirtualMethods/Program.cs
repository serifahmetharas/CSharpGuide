using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance yaptığımız ortamda genel olmayan,değişkenlik gösterebilecek methoları override edip istediğimiz şekilde kullanabilmemizi sağlar.
            // Aşağıda Sql için virtual method override edildi, Mysql için edilmedi.
            
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add() // Override edip Inherit edeceğimiz yerde bu methodu farklı bir şekilde kullanabilmemize olanak sağlar.
        {
            Console.WriteLine("Added by default.");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default.");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL"); // Database de virtual olarak oluşturduğumuz methodu burada override ettik ve Sql kullandığımızda method bu şekilde çalıştı.
            // base.Add(); Eğer Database ile aynı işlemi yapsın istiyorsan bunu yazarsın.
        }
    }

    class MySql : Database
    {

    }


}
