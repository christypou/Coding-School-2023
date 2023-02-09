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
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null)
            {
                return;
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
            return context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
        }

        public void Update(int id, Manager entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null)
            {
                return;
            }
            dbManager.SalaryPerMonth = entity.SalaryPerMonth;
            dbManager.Surname = entity.Surname;
            dbManager.Name = entity.Name;
            context.SaveChanges();
        }
    }
}
