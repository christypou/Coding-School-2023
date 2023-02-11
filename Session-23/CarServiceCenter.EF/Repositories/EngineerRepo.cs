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
    internal class EngineerRepo : IEntityRepo<Engineer>
    {
        public void Add(Engineer entity)
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
            var dbEngineer = context.Engineers.SingleOrDefault(engineer => engineer.Id == id);
            if (dbEngineer is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbEngineer);
            context.SaveChanges();
        }

        public IList<Engineer> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.Engineers.Include(engineer => engineer.Manager).ToList();
        }

        public Engineer? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.Engineers.Include(engineer=>engineer.Manager).SingleOrDefault(engineer => engineer.Id == id);
        }

        public void Update(int id, Engineer entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbEngineer = context.Engineers.Include(engineer=>engineer.Manager).SingleOrDefault(engineer => engineer.Id == id);
            if (dbEngineer is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbEngineer.SalaryPerMonth = entity.SalaryPerMonth;
            dbEngineer.Name = entity.Name;
            dbEngineer.Surname = entity.Surname;
            context.SaveChanges();
        }
    }
}
