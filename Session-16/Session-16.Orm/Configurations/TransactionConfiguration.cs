using LibCarService;
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
    public class TransactionsConfiguration : IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(Transaction => Transaction.ID);
            builder.Property(Transaction=>Transaction.TotalPrice).HasPrecision(10);

            builder.HasOne(transaction => transaction.Customer)
                .WithOne(customer => customer.Transaction)
                .HasForeignKey<Transactions>(transaction => transaction.ID);
            builder.HasOne(transaction => transaction.Car)
                .WithOne(car => car.Transaction)
                .HasForeignKey<Transactions>(transaction => transaction.ID);
            builder.HasOne(transaction => transaction.Manager)
                .WithOne(manager => manager.Transaction)
                .HasForeignKey<Transactions>(transaction => transaction.ID);
            //builder.HasOne(transaction => transaction.CarServiceCenter)
            //    .WithOne(carServiceCenter => carServiceCenter.Transactions)
            //    .HasForeignKey<Transactions>(transaction => transaction.ID);
        }
    }
}
