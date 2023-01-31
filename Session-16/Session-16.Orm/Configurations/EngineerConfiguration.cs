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
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.ToTable("Engineer");
            builder.HasKey(Engineer => Engineer.ID);
            builder.Property(Engineer => Engineer.Name).HasMaxLength(30);
            builder.Property(Engineer => Engineer.Surname).HasMaxLength(30);
            builder.Property(Engineer => Engineer.SalaryPerMonth).HasPrecision(10);

            builder.HasOne(engineer => engineer.Manager)
               .WithOne(manager => manager.Engineer)
               .HasForeignKey<Engineer>(engineer => engineer.ManagerID);
            
        }
    }
}
