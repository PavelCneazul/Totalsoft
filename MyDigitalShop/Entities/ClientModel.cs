using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientModel
    {
        public int ClientId { get; set; }

        public string ClientName { get; set; }

        public string ClientSurname {get;set;}

        public string CodeClient { get; set; }

        public string Fullname { get; set; }

       
        public override string ToString()
        {
            return Fullname;
        }
    }
}
