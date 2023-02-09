using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class TransactionLinesRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLines = context.TransactionLines.Where(transactionLines => transactionLines.Id == id).SingleOrDefault();
            if (dbTransactionLines is null)
            {
                return;
            }
            context.Remove(dbTransactionLines);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Where(transactionLines => transactionLines.Id == id).SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLines = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (dbTransactionLines is null)
            {
                return;
            }
            dbTransactionLines.PricePerHour = entity.PricePerHour;
            dbTransactionLines.Price = entity.Price;
            dbTransactionLines.Hours = entity.Hours;
        }
    }
}
