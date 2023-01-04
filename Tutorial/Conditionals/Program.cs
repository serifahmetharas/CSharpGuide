using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ekrana girilen değeri karşılaştırma.

            // If Condition
            var number = Convert.ToInt32(Console.ReadLine());
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }

            // Single Line If
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            // else if yapısı
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20.");
            }


            // Switch-case yapısı.
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20.");
                    break;
            }

            // Çoklu şartlar 
            if (number >= 0 && number <= 100) // AND 
            {
                Console.WriteLine("Number is between 0-100.");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200.");
            }
            else if (number > 200 || number<0 ) // OR
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }


            Console.ReadLine();
        }
    }
}
