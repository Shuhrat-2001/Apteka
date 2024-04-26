using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.ManufacturerRequests
{
    public record CreateManufacturerRequests
    {
        public string Name { get; set; }
        public string CountryOfProduction { get; set; }
    }
}
