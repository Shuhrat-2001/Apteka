using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.MedicationRequests
{
    public record DeletemedicationRequests
    {
        public Guid Id { get; set; }
    }
}
