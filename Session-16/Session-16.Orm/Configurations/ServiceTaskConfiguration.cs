using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations
{
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ServiceTask> builder)
        {
            builder.ToTable("Service Task");
            builder.HasKey(ServiceTask => ServiceTask.ID);
            builder.Property(ServiceTask=>ServiceTask.Description).HasMaxLength(200);
            builder.Property(ServiceTask => ServiceTask.Hours).HasPrecision(10);

        }
    }
}
