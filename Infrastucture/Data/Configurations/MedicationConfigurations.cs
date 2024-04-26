using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations 
{ 

namespace Infrastructure.Data.Configurations
{
    public class MedicationConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure(EntityTypeBuilder<Medication> builder)
        {
            builder.HasKey(m => m.Id); //Primary key

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(m=> m.PeriodOfUse)
                .IsRequired();

            builder.Property(m => m.Price)
                .IsRequired()
                .HasPrecision(4, 2);

            builder.Property(m => m.Types)
                .IsRequired();

            builder.HasOne(m => m.GroupOfMedication)
                .WithMany(m => m.Medications)
                .HasForeignKey(m => m.GroupOfMedicationId); //Foreign key

            builder.HasOne(m => m.Manufacturer)
                .WithMany(m => m.Medications)
                .HasForeignKey(m => m.ManufacturerId);  //Foreign key
        }
    }
}

