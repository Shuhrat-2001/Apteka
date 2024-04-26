using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public record SingleMedicationResponses
    {
        public int Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfProduction { get; set; }
        public int PeriodOfUse { get; set; }
        public TypeOfMedication TypeOfMedication { get; set; }
        public Types Types { get; set; }
        public Guid GroupOfMedicationId { get; set; }
        public Guid ManufacturerId { get; set; }
    }
}
