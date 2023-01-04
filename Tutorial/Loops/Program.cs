using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop
            // 1den 100e kadar sayıları yazdırma
            for (int i = 1; i <= 100; i++) // (Başlangıç,Şart,Artış)
            {
                Console.WriteLine(i);
            }

            //While Loop
            // 100den geriye saydırma.
            int number1 = 100;
            while (number1>0) // Koşul
            {
                Console.WriteLine(number1);
                number1--; // Number1 değerini 1 azalt.
            }

            // Do While Loop
            // 10dan geriye saydırma.
            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;
            } while (number2>0);

            //Foreach Loop
            //Bir koleksiyonun öğelerini numaralandırır ve onun gövdesini koleksiyonun her öğesi için yürütür.
            string[] students = new string[3] { "Serif", "Afra", "Ali" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            



            Console.ReadLine();

        }
    }
}
