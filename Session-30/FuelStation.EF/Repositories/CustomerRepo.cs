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
	public class CustomerRepo : IEntityRepo<Customer>
	{
		public void Add(Customer entity)
		{
			using var context = new FuelStationDbContext();
			if (entity.Id != 0)
			{
				throw new ArgumentException("Given entity should not have Id set", nameof(entity));

			}
			context.Add(entity);
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			using var context = new FuelStationDbContext();
			var dbCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
			if (dbCustomer is null)
			{
				throw new KeyNotFoundException($"Given id '{id}' was not found in database");
			}
			context.Remove(dbCustomer);
			context.SaveChanges();

		}

		public IList<Customer> GetAll()
		{
			using var context = new FuelStationDbContext();
			return context.Customers.Include(customer => customer.Transactions).ToList();
		}

		public Customer? GetById(int id)
		{
			using var context = new FuelStationDbContext();
			return context.Customers
				.Include(customer => customer.Transactions)
				.SingleOrDefault(customer => customer.Id == id);
		}

		public void Update(int id, Customer entity)
		{
			using var context = new FuelStationDbContext();
			var dbCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
			if (dbCustomer is null)
			{
				throw new KeyNotFoundException($"Given id '{id}' was not found in database");
			}
			dbCustomer.CardNumber = entity.CardNumber;
			dbCustomer.Name = entity.Name;
			dbCustomer.Surname = entity.Surname;
			context.SaveChanges();
		}
	}
}
