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
    public class TransactionLinesRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new CarServiceCenterDbContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLines = context.TransactionLines.SingleOrDefault(transactionLines => transactionLines.Id == id);
            if (dbTransactionLines is null)
            {
                return;
            }
            context.TransactionLines.Remove(dbTransactionLines);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.
                Include(transactionLine=>transactionLine.Engineer).
                Include(transactionLine => transactionLine.Transaction).
                Include(transactionLine=>transactionLine.ServiceTask).ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.
                Include(transactionLine => transactionLine.Engineer).
                Include(transactionLine => transactionLine.Transaction).
                Include(transactionLine => transactionLine.ServiceTask).SingleOrDefault(transactionLines => transactionLines.Id == id);
        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLines = context.TransactionLines.
                Include(transactionLine => transactionLine.Engineer).
                Include(transactionLine => transactionLine.Transaction).
                Include(transactionLine => transactionLine.ServiceTask).SingleOrDefault(transactionLine => transactionLine.Id == id);
            if (dbTransactionLines is null)
            {
                return;
            }
            dbTransactionLines.PricePerHour = entity.PricePerHour;
            dbTransactionLines.Price = entity.Price;
            dbTransactionLines.Hours = entity.Hours;
            dbTransactionLines.TransactionId = entity.TransactionId;
            dbTransactionLines.EngineerId = entity.EngineerId;
            dbTransactionLines.ServiceTaskId= entity.ServiceTaskId;
            context.SaveChanges();
        }
    }
}
