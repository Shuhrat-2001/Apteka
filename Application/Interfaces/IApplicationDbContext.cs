using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Medication> medications { get; set; }
        DbSet<Manufacturer> Manufacturers { get; set; }
        DbSet<Order> GetOrders();
        void SetOrders(DbSet<Order> value);
        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<GroupOfMedication> GroupOfMedications { get; set; }
        DbSet<BankAccount> Accounts { get; set; }
    }
}
