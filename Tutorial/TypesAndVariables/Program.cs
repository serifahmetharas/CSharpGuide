using System;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            int number1 = 10; // 32bit
            Console.WriteLine(number1);
            Console.WriteLine("Number1 is {0}", number1);

            long number2 = 2415321312; // 64bit
            Console.WriteLine("Number2 is {0}", number2);

            short number3 = -32768; // 16bit
            Console.WriteLine("Number3 is {0}", number3);

            byte number4 = 255; // 8bit

            bool condition = false; // True-False condition

            char character = 'A'; // ASCII
            Console.WriteLine("Character is {0}", character);
            //ASCII karşılığı
            Console.WriteLine("Character is {0}", (int)character);

            string City = "Ankara"; // Char Array

            double number5 = 10.4; // 64bit Ondalik
            Console.WriteLine("Number5 is {0}", number5);

            decimal number6 = 10.4m; // long double (m zorunlu)
            Console.WriteLine("Number6 is {0}", number6);

            /*
             Days.Friday
             Days.Sunday 
             gibi kullanımlar mümkün.
            */

            //Örtülü değişken
            var number7 = 10; // Şeklinde değişkenini oluşturup. 
            Console.WriteLine(number7); // Şeklinde yazdırabilirsin.
                                        // Ancak bu değer artık int olarak atanmıştır, string gibi bir değer ile yeniden değiştiremezsin.

        }

        enum Days
        {
            Monday = 41, Tuesday = 12, Wednesday = 21, Thursday = 54, Friday = 42, Saturday = 62, Sunday = 37 // Default 0,1,2,3...
        }

    }
}

