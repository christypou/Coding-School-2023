using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
	public class TransactionRepo : IEntityRepo<Transaction>
	{
		public void Add(Transaction entity)
		{
			using var context = new FuelStationDbContext();
			if (entity.Id != 0)
			{
				throw new ArgumentException("Given entity should Have ID set,", nameof(entity));
			}
			context.Add(entity);
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			using var context = new FuelStationDbContext();
			var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
			if (dbTransaction is null)
			{
				throw new KeyNotFoundException($"Given id'{id}' was not found in database");
			}
			context.Remove(dbTransaction);
			context.SaveChanges();
		}

		public IList<Transaction> GetAll()
		{
			using var context = new FuelStationDbContext();
			return context.Transactions.
				Include(transaction => transaction.Customer).
				Include(transaction => transaction.Employee).
				Include(transaction => transaction.TransactionLines).
				ToList();
		}

		public Transaction? GetById(int id)
		{
			using var context = new FuelStationDbContext();
			return context.Transactions.
				Include(transaction => transaction.Customer).
				Include(transaction => transaction.Employee).
				Include(transaction => transaction.TransactionLines).
				SingleOrDefault(Transaction => Transaction.Id == id);
		}

		public void Update(int id, Transaction entity)
		{
			using var context = new FuelStationDbContext();
			var dbTransaction = context.Transactions.
				Include(transaction => transaction.Customer).
				Include(transaction => transaction.Employee).
				Include(transaction => transaction.TransactionLines).
				SingleOrDefault(transaction => transaction.Id == id);
			if (dbTransaction is null)
			{
				throw new KeyNotFoundException($"Given id '{id}' was not found in database");
			}
			dbTransaction.PaymentMethod= entity.PaymentMethod;
			dbTransaction.TotalValue= entity.TotalValue;
			dbTransaction.EmployeeId= entity.EmployeeId;
			dbTransaction.CustomerId= entity.CustomerId;
			context.SaveChanges();
		}
	}
}
