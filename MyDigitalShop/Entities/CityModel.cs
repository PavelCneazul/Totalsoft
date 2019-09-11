using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CityModel
    {
        public int CityId { get; set; }
        public string CityName { get; set; }

        public CountyModel County { get; set; }
        public CityModel()
        {
        }

        public override string ToString()
        {
            return CityName;
        }
    }
}
