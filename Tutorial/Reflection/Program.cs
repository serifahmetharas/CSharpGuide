using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              DortIslem dortIslem = new DortIslem(2, 3);
              dortIslem.Topla(3,4); // Sayı vermen gerekiyor.
              dortIslem.Topla2(); //  Sayıya gerek yok çünkü constructordan gelen değeri kullandık.

            */

            /*
            // Reflection ile yaparsak;

            var type = typeof(DortIslem);
            // var dortIslem = Activator.CreateInstance(type);
            //yada
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type);
            int result = dortIslem.Topla(4, 5); // Bunun çalışması için DortIslem de parametresiz bir contructor da mutlaka olmalı.
            Console.WriteLine(result);

            // Parametresiz methodları, yani parametreli contructor ı da kullanabilmek için yukarıdaki ifadeyi;
            // DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7); şeklinde kullanabiliriz.
            // Artık bu sayede dortIslem.Topla2(); işlemini yapıp 13 değerini alabiliriz.

            */

            /*
             * Daha profesyonel bir şekilde kullanacak olursak:

            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 6, 7);
            instance.GetType().GetMethod("Topla2").Invoke(instance, null);

            // Yani GetMethodla istediğimiz methoda ulaşır, Invoke ile o methodu çalıştırabiliriz.
            // Yazdırırsak yine 13 değerini alabiliriz.

            

            */

            /*
            GetType ile instance ın type ını çağırırsın. Get Method ile Method info alırsın.
            Invoke ile de bunu çağırırsın.
            Yani aslında şu şekilde bir yaklaşımla DAHA DA PROFESYONEL bir kullanım mevcut:
            */

            var type = typeof(DortIslem);

            var instance = Activator.CreateInstance(type, 6, 5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            methodInfo.Invoke(instance, null); // Hangi örneğin Topla2 si çalıştırılacak anlamında instance yazılır.
                                               // Yazdırırsan 11 verir. 

            // Bir class ın tüm methodlarını, parametrelerini ve attribute özelliklerini okumak:

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method adi: {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    {
                        Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
                    }
                }



            }

            Console.ReadLine();
        }

        public class DortIslem
        {
            int _sayi1;
            int _sayi2;

            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public DortIslem()
            {

            }
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }

            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }

            [MethodName("Carpma")]
            public int Carp2()
            {
                return _sayi1 * _sayi2;
            }


        }

        public class MethodNameAttribute : Attribute // Attribute tanımlaması bu şekilde yapılır.
        {
            private string _name;

            public MethodNameAttribute(string name)
            {
                _name = name;
            }
        }
    }
}
