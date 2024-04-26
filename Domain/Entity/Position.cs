using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Position:BaseEntity
    {
        public string Name { get; set; }
        public string Discription {  get; set; }    
    }
}
