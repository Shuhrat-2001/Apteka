using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Medication : BaseEntity
    {
        public int Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfProduction { get; set; }
        public Types Types { get; set; }
        public TypeOfMedication TypeOfMedication { get; set; }
        public int PeriodOfUse { get; set; }
        public GroupOfMedicine GroupOfMedicine { get; set; }
        public Guid GroupOfMedicineId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Guid ManufacturerId { get; set; }

    }
}