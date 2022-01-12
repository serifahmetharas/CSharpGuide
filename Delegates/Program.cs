using System;

namespace Delegates
{
    public delegate void MyDelegate(); // void olan ve parametre almayan methodlara delegelik.
    public delegate void MyDelegate2(string text); // void olan ve parametre alan methoda delegelik.
    public delegate int MyDelegate3(int number1, int number2); // int döndüren ve int parametreler içeren methoda delegelik.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // Classlar ile method çağırmak.
            customerManager.SendMessage();
            customerManager.ShowAlert();

            Console.WriteLine("----------------------------");

            // delegates ile method çağırmak:

            MyDelegate myDelegate = customerManager.SendMessage; // MyDelegates ile methoda myDelegate elçisini atadık.
                                                                 //Bu şekilde MyDelegates ile farklı methodlara farklı elçiler de atanabilir.
            myDelegate(); // Elçiyle methodu çalıştırma.

            myDelegate += customerManager.ShowAlert; // Elçimize yeni method ekleme. (Aynı şekilde çıkarma da yapılabilir.)
            myDelegate(); // Çalıştırma.

            Console.WriteLine("---------------------------");

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("TEXT"); // Bu şekilde myDelegate2 elçisindeki içi method çalışır ancak içindeki parametre ikisinde de aynı olacak şekilde çalışmış olur.

            Console.WriteLine("------------------");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc); // Method çalışır ve 5 değerini verir.
            
            myDelegate3 += matematik.Carp;
            var result = myDelegate3(2,3);
            Console.WriteLine(result);  // 6 değerini verir çünkü parametreli methodlarda delegeler parametreyi en son eklenen method için kullanır.

            Console.WriteLine("-------------------");
            
            // Func ile method çalıştırma.
            // <parametre,parametre,dönüştipi>    

            Func<int, int, int> add = matematik.Topla; // Delege gibi parametresiz delege tanımla.
            var sonuc1 = add(2, 3);
            Console.WriteLine(sonuc1); // Func ile Topla methodunu çalıştırmış olup 5 çıktısını alırız.

            Console.WriteLine("------------");
            
            // Mesela Func delegasyonunu kullanarak random sayı üreten bir operatör oluşturalım.
            // Tek int yani sadece output var, parametre yok.
            // Adını delegate olarak tanımlarken blok içinde gerçekleşecek işlemi yazalım.
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber()); 

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

    }

    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }


    }
}
