using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public record SingleManufacturerResponses
    {
        public string Name { get; set; }
        public string CountryOfProduction { get; set; }
    }
}
