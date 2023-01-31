using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm
{
    public class CarServiceContext : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Engineer> Engineer { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<ServiceTask> ServiceTask { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionLine> transactionLine { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //change --------------------------------------------
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");

            base.OnConfiguring(optionsBuilder);
        }


    }
}
