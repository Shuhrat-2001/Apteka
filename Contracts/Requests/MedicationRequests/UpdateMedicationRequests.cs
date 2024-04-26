using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.MedicationRequests
{
    public record UpdateMedicationRequests
    {
        public int Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfProduction { get; set; }
        public int PeriodOfUse { get; set; }
        public TipeOfMedicine TipeOfMedicine { get; set; }
        public Types Types { get; set; }
        public Guid GroupOfMedicationId { get; set; }
        public Guid ManufacturerId { get; set; }
    }
}
