using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations
{
    public class CarServiceCenterConfiguration : IEntityTypeConfiguration<CarServiceCenter>
    {
        public void Configure(EntityTypeBuilder<CarServiceCenter> builder)
        {
            builder.ToTable("Car Service Center");
            builder.HasKey(CarServiceCenter => CarServiceCenter.ID);

        }
    }
}
