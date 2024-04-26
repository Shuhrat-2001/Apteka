using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.GroupOfMadicationRequests
{
    public record CreateGroupOfMadicationRequests
    {
        public string name { get; set; }
    }
}
