using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface hiçbir zaman tek başına newlenemez. Tek başına hiçbir anlamı yoktur. Soyut nesnedir.
            // Bu örnekte dosyalar interface i dosyalar kullanarak çalışacağız.

            // Yönetim classımızı newliyoruz ve burada ICostumerDal olarak tanımlı methodumuzu ister SQL ister Oracle olarak kullanıyoruz.
            // SQL yada Oracle seçimine göre gerçekleşen işlem değişir.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            

        }
    }
}

