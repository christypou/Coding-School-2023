using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class ServiceTaskRepo : IEntityRepo<ServiceTask>
    {
        public void Add(ServiceTask entity)
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
            var dbServiceTask = context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.Id == id);
            if (dbServiceTask is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbServiceTask);
            context.SaveChanges();
        }

        public IList<ServiceTask> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.ToList();
        }

        public ServiceTask? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.Id == id);
        }

        public void Update(int id, ServiceTask entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbServiceTask = context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.Id == id);
            if (dbServiceTask is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbServiceTask.Code = entity.Code;
            dbServiceTask.Description = entity.Description;
            dbServiceTask.Hours = entity.Hours;
            context.SaveChanges();
        }
    }
}
