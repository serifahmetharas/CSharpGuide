using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        // Prop yaz 2 kere tab a bas ve property ni tanımla.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        // Bu sayede bu property ler bu class içinde tanımlıdır ve rahatça kullanılabilir.
    }
}
