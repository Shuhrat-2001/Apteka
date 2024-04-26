using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public Status Status { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        public Payment Payment { get; set; }
        public Guid PaymentId { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public Medication Medication { get; set; }
        public Guid MedicationId { get; set; }
    }
}
