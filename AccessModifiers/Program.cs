using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
           // private sadece tanımlandığı blok içerisinde geçerlidir.
           // int default olarak private.

           // protected da tanımlandığı tüm blokta geçerlidir. 
           // class seviyesinde kullanılır ve private den farkı Inherit ettiğimiz classlarda da kullanabilmemize olanak sağlar.

           // internal class ın default udur.
           // internal bir class ı bağlı bulunduğu projenin tamamında kullanabilirsin.
           // Eğer bir class ı başka projelerde de kullanabilmek istiyorsan public olarak belirtmeli ve referans göstermelisin.
           // Class ı private olarak ancak iç içe classlarda kullanabilirsin, yoksa mantığı yok.
           
           //public te erişim kısıtlaması yoktur.




        }
    }

}
