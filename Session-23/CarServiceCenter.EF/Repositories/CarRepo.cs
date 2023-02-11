using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class CarRepo : IEntityRepo<Car>
    {
        public void Add(Car entity)
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
            var dbCar = context.Cars.SingleOrDefault(car => car.Id == id);
            if (dbCar is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbCar);
            context.SaveChanges();
        }

        public IList<Car> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.ToList();
        }

        public Car? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.SingleOrDefault(car => car.Id == id);
        }

        public void Update(int id, Car entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbCar = context.Cars.SingleOrDefault(car => car.Id == id);
            if (dbCar is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCar.Brand = entity.Brand;
            dbCar.CarRegistrationNumber = entity.CarRegistrationNumber;
            dbCar.Model = entity.Model;
            context.SaveChanges();  
        }
    }
}
