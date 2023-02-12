using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new CarServiceCenterDbContext();
            context.Transactions.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
            if (dbTransaction is null)
            {
                return;
            }
            context.Transactions.Remove(dbTransaction);
            context.SaveChanges();

        }

        public IList<Transaction> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.
                Include(transaction=>transaction.Customer).
                Include(transaction => transaction.Manager).
                Include(transaction => transaction.Car).
                Include(transaction => transaction.TransactionLines).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.
                Include(transaction => transaction.Customer).
                Include(transaction => transaction.Manager).
                Include(transaction => transaction.Car).
                Include(transaction => transaction.TransactionLines).SingleOrDefault(transaction => transaction.Id == id);
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransaction = context.Transactions.
                Include(transaction => transaction.Customer).
                Include(transaction => transaction.Manager).
                Include(transaction => transaction.Car).
                Include(transaction => transaction.TransactionLines).SingleOrDefault(transaction => transaction.Id == id);
            if (dbTransaction is null)
            {
                return;
            }
            dbTransaction.TotalPrice = entity.TotalPrice;
            dbTransaction.Date = entity.Date;
            dbTransaction.CarId= entity.CarId;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.ManagerId = entity.ManagerId;
            context.SaveChanges();
        }
    }
}
