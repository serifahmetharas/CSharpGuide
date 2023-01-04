using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntroduction();

            // Kendi hata sınıfımızı oluşturma: RecordNotFoundException (Farklı dosya olarak oluşturuldu.)

            try
            {
                FindStudent(); // Öğrenci bulma methodu, eğer bulursa yazdıran bulmazsa hata fırlatan.
            }
            catch (RecordNotFoundException exception) // RecordNotFoundException hatası fırlatıldığında yapılması istenenler bloğu.
            {
                Console.WriteLine(exception.Message);
            };

            // try-catch bloğunun daha sade yazımını sağlamak ve uzatmamak için HandleException methodu:
            // Bu şekilde method oluşturulur ve try-catch blokları methodun içinde sadece bir kere yazılır.

            HandleException(() =>
            {
                FindStudent();
            });

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            // Try-catch buraya yazılır ve bu sayede ana kodda sürekli yazılmak zorunda kalınmaz.

            try
            {
                action.Invoke(); // Action ı Invoke et. Yani HandleException içindeki methodu burda try ın içinde çalıştır demek.
            }
            catch (Exception exception) // Tüm hatalarda hangi hata sınıfındaysak onun mesajını vermesini sağlarız.
            {
                Console.WriteLine(exception.Message); // Mesajı hatayı fırlatırken parantez içine yazabiliriz.
                                                      // Construnctor sayesinde mümkün.
            };
        }

        private static void FindStudent()
        {
            List<string> students = new List<string> { "Serif", "Afra", "Ali" }; // Bir list oluşturduk.

            if (!students.Contains("Ahmet")) // Eğer listede Ahmet yok ise (! kullandık dikkat.) hata fırlatalım.
            {
                throw new RecordNotFoundException("Record Not Found");
                // RecordNotFoundException hatasını fırlat. Yani hata oluştur.
                // Constructor sayesinde artık parantez içini kullanıp hatamızı yönetebiliriz.

            }
            else
            {
                Console.WriteLine("Record Found."); // Eğer var ise bulundu yazısını göster.
            }
        }

        private static void ExceptionIntroduction()
        {
            try // try+2 tab ile bu blokları oluşturuyoruz. try içerisine hata olmamasını beklediğimiz asıl kodu yazıyoruz.
            {
                string[] students = new string[3] { "Serif", "Afra", "Ali" }; // 3 elemanlı bir string array oluşturduğumuzu düşünelim.
                students[3] = "Ahmet"; // 3. indise değer vermeyi denediğimizde bir hata alırız. Ve o yüzden program catch bloğunu çalıştırır.
            }
            catch (Exception exception) // Hata oluştuğu zaman gerçekleşmesini istediğimiz blok.
            {

                Console.WriteLine("EXCEPTION");
                Console.WriteLine(exception.Message); // Catch parantezine bir exception oluşturursak Message komutu ile hata mesajını elde etmek ve yazdırmak mümkün.
                                                      // Ancak genelde bunu kullanıcıya göstermek yerine ileride hatayı yakalamak üzere veritabanına loglarız.
                Console.WriteLine(exception.InnerException); // Message komutunun daha detaylı halidir. Bir alternatiftir. (Bu örnek için mevcut değil.)

            }

            // Uzun bloklarla aldığımız farklı hatalara göre davranabildiğimiz bir yapı oluşturabiliriz.

            try
            {
                // KOD BLOĞU
            }
            catch (IndexOutOfRangeException exception) // Bir hata türü belirledik. Eğer bu hata gerçekleştiyse bu blok uygulanıyor. Değilse sıradaki sorgulanacak.
                                                       // Yandaki exception, eğer kullanılacaksa tanımlanıyor yoksa yazmak zorunlu değil.
            {

                Console.WriteLine(exception.Message); // Bu hata geldiğinde kullanıcıya yazdırmasını istedik.

            }
            catch (Exception) // Eğer hata yukarıdaki gibi değilse, burayı sorgular. Exception tüm hepsini kapsadığından şu an burası çalışır.
            {
                Console.WriteLine("Bir hata olustu."); // Kullanıcıya hatayı bu şekilde belirtmek istedik.
            }
        }
    }
}
