using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
  
        public void Add(Customer entity)
        {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
            {
                return;
            }
            context.Remove(dbCustomer);
            context.SaveChanges();

        }

        public IList<Customer> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.Customers.Where(customer => customer.Id== id).SingleOrDefault();

        }

        public void Update(int id, Customer entity )
        {
            using var context = new CarServiceCenterDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if(dbCustomer is null)
            {
                return;
            }
            dbCustomer.Phone = entity.Phone;
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Tin = entity.Tin;
            context.SaveChanges();
        }


    }
}
