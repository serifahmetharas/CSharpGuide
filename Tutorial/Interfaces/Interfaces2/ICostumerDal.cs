using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    interface ICostumerDal
    {
        // Interface içinde sadece method isimlerini giriyoruz.
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICostumerDal // SQL Veritabanı için gerekli blok.
    {
        // Interface in methodlarını implement ediyoruz. 
        // Çalışma bloklarını doldurduğumuz yer burası.
        public void Add()
        {
            Console.WriteLine("SQL Added.");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated.");
        }
    }

    class OracleServerCustomerDal : ICostumerDal // Oracle veritabanı için gerekli blok.
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated.");
        }

    }

    class CustomerManager // İstediğimiz veritabanını kullanabileceğimiz yönetim sınıfı. Newledikten sonra Oracle yada SQL çağırmak yeterli.
    {
        public void Add(ICostumerDal costumerDal)
        {
            costumerDal.Add();
        }
        public void Delete(ICostumerDal costumerDal)
        {
            costumerDal.Delete();
        }
        public void Update(ICostumerDal costumerDal)
        {
            costumerDal.Update();
        }
    }
}
