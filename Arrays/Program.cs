using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir öğretmenin öğrencileri olsun.
            string student1 = "Serif";
            string student2 = "Afra";
            string student3 = "Ali";
            // Bu şekilde tek tek her birini yönetmek zor. Burada array(dizi)lerden yararlanırız.

            // string türde öğrenciler array i tanımlayalım.
            string[] students = new string[3]; // 3 elemanlı students adında string türünde bir array.
            students[0] = "Serif";
            students[1] = "Afra";
            students[2] = "Ali";

            // Students[3] = "Alper" ; dersen hata verir çünkü 3 elemanlı yani 0,1,2 indisli bir array oluşturmuştuk.

            // Array sayesinde tek işlemle bu öğrencilerin hepsiyle çalışabiliriz. Örneğin isimlerini yazdıralım:
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Arrayi hem üretip hem de içini doldurabildiğimiz daha kısa bir notasyon:
            string[] students2 = new[] { "Serif", "Afra", "Ali" };
            //Yazdırdığımızda üstteki newleme işlemiyle aynı olduğunu görürüz.
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            // Çok Boyutlu Diziler

            string[,] regions = new string[5, 3] // 5 Satır ve 3 Sütundan oluşan çok boyutlu bir dizi oluşturmuş ve doldurmuş olduk.
            {
               {"İstanbul","İzmit","Balıkesir"},
               {"Ankara","Konya","Kırıkkale"},
               {"Antalya","Adana","Mersin"},
               {"Rize","Trabzon","Samsun"},
               {"İzmir","Muğla","Manisa"}
            };

            // Çok Boyutlu Dizilerin Yazdırılması
            for(int i = 0; i <= regions.GetUpperBound(0); i++) // Dimension 0 yani 5 için.
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) // Dimension 1 yani 3 için.
                {
                    Console.Write(regions[i, j]+"  ");
                }

                Console.WriteLine();
            }







        }
    }
}
