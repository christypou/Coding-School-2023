using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.TIN).HasMaxLength(10);
            builder.Property(customer => customer.Phone).HasMaxLength(15);
            builder.Property(customer => customer.Name).HasMaxLength(20);
            builder.Property(customer => customer.Surname).HasMaxLength(20);

        }
    }
}
