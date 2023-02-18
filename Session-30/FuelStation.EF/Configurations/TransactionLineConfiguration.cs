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
	public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
	{
		public void Configure(EntityTypeBuilder<TransactionLine> builder)
		{
			builder.ToTable("TransactionLines");

			// Primary Key
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Id).ValueGeneratedOnAdd();
			builder.Property(t => t.Quantity).HasPrecision(9, 2).IsRequired();
			builder.Property(t => t.ItemPrice).HasPrecision(9, 2).IsRequired();
			builder.Property(t => t.NetValue).HasPrecision(9, 2).IsRequired();
			builder.Property(t => t.DiscountPercent).HasPrecision(5, 2).IsRequired();
			builder.Property(t => t.DiscountValue).HasPrecision(9, 2).IsRequired();
			builder.Property(t => t.TotalValue).HasPrecision(9, 2).IsRequired();

			builder.HasOne(t => t.Transaction)
			 .WithMany(t => t.TransactionLines)
			 .HasForeignKey(t => t.TransactionId)
			 .OnDelete(DeleteBehavior.Restrict);
			
			builder.HasOne(t => t.Item)
			 .WithMany(t => t.TransactionLines)
			 .HasForeignKey(t => t.ItemId)
			 .OnDelete(DeleteBehavior.Restrict);
		}
	}
}
