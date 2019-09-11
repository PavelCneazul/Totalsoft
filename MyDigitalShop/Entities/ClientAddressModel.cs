using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientAddressModel
    {
        public int ClientAddressId { get; set; }
        public string Adresa { get; set; }

        public ClientModel Client { get; set; }
        public ClientAddressModel()
        {
        }

        public override string ToString()
        {
            return Adresa;
        }
    }
}
