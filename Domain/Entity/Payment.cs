using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Payment:BaseEntity
    {
        public DateTime PaymentDate { get; set; }
        public Order Order { get; set; }
        public Guid OrderId { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
