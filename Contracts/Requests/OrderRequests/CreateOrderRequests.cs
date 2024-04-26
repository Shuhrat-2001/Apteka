﻿using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.Orderrequests
{
    public record CreateOrderRequests
    {
        public DateTime OrderDate { get; set; }
        public Status Status { get; set; }
        public Guid CustomerId { get; set; }
        public Guid PaymentId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid MedicationId { get; set; }
    }
}
