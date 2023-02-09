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
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbServiceTask = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
            if (dbServiceTask is null)
            {
                return;
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
            return context.ServiceTasks.Where(serviceTask=> serviceTask.Id == id).SingleOrDefault();
        }

        public void Update(int id, ServiceTask entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbServiceTask = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
            if (dbServiceTask is null)
            {
                return;
            }
            dbServiceTask.Code = entity.Code;
            dbServiceTask.Description = entity.Description;
            dbServiceTask.Hours = entity.Hours;
            context.SaveChanges();
        }
    }
}
