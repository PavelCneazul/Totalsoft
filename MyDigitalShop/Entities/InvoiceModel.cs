using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceModel
    {
       public InvoiceModel()
        {
        }

        public int InvoiceId { get; set; }
        public int ClientAddressId { get; set; }
        public int ClientId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string Address { get; set; }
        public string Obesrvations { get; set; }

    }
}
