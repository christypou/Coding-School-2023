using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
	public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{

			builder.ToTable("Customers");
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Id).ValueGeneratedOnAdd();
			builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
			builder.Property(t => t.Surname).HasMaxLength(100).IsRequired();
			builder.Property(t => t.CardNumber).HasMaxLength(15).IsRequired();
			
		}
	}
}
