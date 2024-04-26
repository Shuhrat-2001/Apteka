using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class GroupOfMedication:BaseEntity
    {
        public string name { get; set; }
        public object Medications { get; set; }
    }
}
