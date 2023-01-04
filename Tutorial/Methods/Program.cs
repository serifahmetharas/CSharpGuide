using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değer döndürmeyen
            Add1();

            // Değer döndüren.
            Console.WriteLine(Add2(3, 6));

            // İki parametreli method, number1 için 3 tanımlandı fakat number2 default olarak 30 alındı.
            Console.WriteLine(Add3(3));

            

            // ref keyword ile fonksiyonu çağırdık ve method içindeki number1 i methoddan referans alarak kullanmış olduk.
            // Ana fonksiyonda yine number1 için sayı atamak zorundasın ama asıl değerini methoddan referans alıyor.
            int number1 = 50;
            Console.WriteLine(Add4(ref number1, 70));

            // out keywordde görüldüğü üzere ise ana fonksiyonda sayi1 e sayı atamak zorunda kalmadan,
            // direk methodun içindeki sayi1 i referans olarak aldık. ref keyword ile farkı budur.

            int sayi1;
            Console.WriteLine(Add5(out sayi1, 90));

            // Overloading ile hem 2 sayıyı hem de 3 sayıyı çarpabilen bir method oluşturduk ve uyguluyoruz.
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            // params keyword ile dizi kullanarak overloading yaptığımız method.
            Console.WriteLine(Sum(3,4,5,10));


            Console.ReadLine();

        }

        // Değer döndürmeyen.
        static void Add1()
        {
            Console.WriteLine("Added.");
        }

        // Değer döndüren. result ile int döndürüyoruz.
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        // Default parametreli method.
        // Eğer y değeri verilmezse default olarak 30.
        // Default parametreler sonra yer almalıdır.
        static int Add3(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        // ref keyword ile çalışmak. 
        // Eğer fonksiyon içindeki number1 i ana fonksiyonda da geçerli olmasını istiyorsak ref keyword kullanırız.
        // Fakat yine de ana fonksiyonda number1 için bir değer mutlaka tanımlamalısın. Tanımlamak istemiyorsan out keyword ile çalışmalısın.
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // out keyword ile çalışmak.

        static int Add5(out int sayi1, int sayi2)
        {
            sayi1 = 100;
            return sayi1 + sayi2;
        }

        // MethodOverloading
        // Bir methodun çeşitli şekillerde kullanımını sağlar.
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        
        static int Multiply(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        // params keyword ile overlading i dizi formatıyla yaparak çok elemanlı işlemleri tek method ile gerçekleştirebiliriz.

        static int Sum(params int[] numbers)
        {
            return numbers.Sum(); // Dizilerde sayıları toplamamızı sağlayan bir fonksiyon. using System.Linq 
        }



    }
}
