using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class ManagerRepo : IEntityRepo<Manager>
    {
        public void Add(Manager entity)
        {
            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.SingleOrDefault(manager => manager.Id == id);
            if (dbManager is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbManager);
            context.SaveChanges();
        }

        public IList<Manager> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.Managers.ToList();
        }

        public Manager? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.Managers.SingleOrDefault(manager => manager.Id == id);
        }

        public void Update(int id, Manager entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.SingleOrDefault(manager => manager.Id == id);
            if (dbManager is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbManager.SalaryPerMonth = entity.SalaryPerMonth;
            dbManager.Surname = entity.Surname;
            dbManager.Name = entity.Name;
            context.SaveChanges();
        }
    }
}
