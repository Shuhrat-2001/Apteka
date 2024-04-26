using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Responses
{
    public record GetAllMedicationResponses
    {
        public IEnumerable<Medication> Items { get; set; }
    }
}
