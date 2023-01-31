using LibCarService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(car => car.ID);
            builder.Property(car=>car.Model).HasMaxLength(50);
            builder.Property(car => car.Brand).HasMaxLength(50);
            builder.Property(car => car.CarRegistrationNumber).HasMaxLength(50);

        }
    }
}
