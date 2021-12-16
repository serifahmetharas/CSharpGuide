using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class RecordNotFoundException : Exception // Exception ile Inherit ettik ve bunun bir Exception olduğunu söyledik.
                                                     
    {
        // Program içerisinde öğrenci bulma methodu oluşturduk, eğer bulamazsa bu hata sınıfını fırlattık.
        // Methodu try-catch bloğuna yerleştirerek eğer exception oluşursa bu hatanın Message ını yazdırmasını söyledik.
        // Ancak bu kendi hata sınıfımız olduğu için methodumuzda hata bölümünü istediğimiz şekilde kontrol edebilmek için,
        // Bir constructor kullanalım ve artık fonksiyonu kullanalım.

        public RecordNotFoundException(string message):base(message)
        {

        }


    }
}
