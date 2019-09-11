using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class ItemModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        
        public override string ToString()
        {
            return ItemName;
        }

    }
}
