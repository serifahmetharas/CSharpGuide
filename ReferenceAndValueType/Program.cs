using System;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30; // Number2 ile hiçbir alakası kalmamıştır. 
                          // Number2, Number1 in ilk değeri olan 10a eşittir.

            Console.WriteLine(number2); // Atamalar değer üzerinden olduğundan 10 yazdırır.

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };   //101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; //102
            cities2 = cities1; // Array ler referans tipli oldukları için,
                               // Cities 2nin referansı=Cities1 in referansı anlamına gelir.
                               // Cities2 Referamsı 101e dönüyor. İkisi de 101 101 oluyor.
            for (int i = 0; i < cities2.Length; i++)
            {
                Console.WriteLine(cities2[i]);
            } //Ankara Adana Afyon olarak okunur.

            cities1[0] = "Istanbul"; // olarak değiştirirsen 101deki tüm referansları değiştir.
                                     // yani cities2nin referansı Istanbul olarak değişir.
            Console.WriteLine(cities2[0]); // İstanbul olarak okunur.
            // Bu nedenle yapılacak değişikliklerde değer mi atadık referans mı atadık buna dikkat etmemiz gerekir.

            // Bellekte cities1 in yerini ve onun referansını tutan bir yer var.
            //          cities2 nin yerini ve onun referansını tutan bir yer var.
            // Sen cities2=cities1 dediğinde doğal olarak cities2 de cities1 in oraya yerleşeceğinden artık işlemler cities1 i de etkiler.


            
            Console.ReadLine();
        }
    }
}
