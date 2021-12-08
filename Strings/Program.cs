using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stringler birer char arraydir.
            string city1 = "Ankara";
            foreach (var item in city1)
            {
                Console.WriteLine(item);
            }

            string city2 = "Istanbul";

            // Stringlerde toplama yaparak yan yana getirebiliriz.
            string result = city1 + city2;
            Console.WriteLine(result);
            //Aynı işlemi bellekte daha az yer kullanarak, fazladan değişken tanımlamadan şu şekilde de gerçekleştirebiliriz:
            Console.WriteLine(String.Format("{0} {1}",city1,city2));

            // String Methods
            string sentence = "My name is Serif Ahmet Haras";

            Console.WriteLine(sentence.Length); // String in karakter sayısını, uzunluğunu verir.
            
            Console.WriteLine(sentence.Clone()); // String in klonunu oluşturur.

            bool result1 = sentence.EndsWith("g"); // Stringin son karakterini sorgular. Bool döndürür. 
            Console.WriteLine(result1); // False değerini verir.
            
            bool result2 = sentence.StartsWith("My name"); // Stringin ilk karakterini sorgular. Bool döndürür.
            Console.WriteLine(result2); // True değerini verir.

            var result3 = sentence.IndexOf("name"); // Stringde "name" kaçıncı karakterde başlıyor onu sorgular.
            Console.WriteLine(result3); // 3 değerini vericektir. Bulamazsa -1 değerini verir.

            var result4 = sentence.LastIndexOf(" "); // Aramaya sondan başlar, bulduğu yerin indisini verir. Performans için işe yarayabilir.
            Console.WriteLine(result4); // 22 değerini verir. Aramayı sondan yapsa bile indis değeri doğrudur.

            var result5 = sentence.Insert(0, "Hello, "); // 0. indisten önce "Hello, " eklenir.

            var result6 = sentence.Substring(3, 4); // String ayırma için kullanılır. 3. indisten itibaren 4 karakter al.
            Console.WriteLine(result6); // name çıktısını verir.

            var result7 = sentence.ToLower();  // Tüm karakterleri küçük harfe çevirir.
            var result8 = sentence.ToUpper(); // Tüm karakterleri büyük harfe çevirir.

            var result9 = sentence.Replace(" ", "-"); // String içindeki tüm boşlukları - ye çevirir.
            
            var result10 = sentence.Remove(2); // 2den itibaren stringi kaldır. "My" çıktısı alınır.


        }
    }
}
