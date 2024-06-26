﻿using Domain.Enum;
using System.Reflection;

namespace Domain.Entities
{
    public class Person : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }

    }
}