using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceDetailModel
    {
        public int InvoiceDetailId { get; set ; }

        public int InvoiceId { get; set; }

        public ItemModel Item { get; set; }

        public decimal Qtty { get; set; }

        public decimal Price { get; set; }

        public decimal Amount { get; set; }

        public string Observations { get; set; }

        public int status { get; set; }
        
    }
}
