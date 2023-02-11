using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenterWeb.Mvc.Models.Car;
using CarServiceCenterWeb.Mvc.Models.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenterWeb.Mvc.Controllers
{
    public class CarController : Controller
    {
        private readonly IEntityRepo<Car> _carRepo;
        public CarController(IEntityRepo<Car> carRepo)
        {
            _carRepo = carRepo;
        }
        // GET: CarController
        public ActionResult Index()
        {
            var cars = _carRepo.GetAll().ToList();
            return View(model: cars);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var cars = _carRepo.GetById(id.Value);
            if (cars == null)
            {
                return NotFound();
            }
            var viewCar = new CarDetailsDto
            {
                Model = cars.Model,
                Brand = cars.Brand,
                CarRegistrationNumber = cars.CarRegistrationNumber,
            };
            return View(model: viewCar);
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarCreateDto car)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCar = new Car(car.Brand, car.CarRegistrationNumber, car.Model);
            _carRepo.Add(dbCar);
            return RedirectToAction("Index");
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbCar = _carRepo.GetById(id);
            if (dbCar == null)
            {
                return NotFound();
            }

            var viewCar = new CarEditDto
            {
                Model = dbCar.Model,
                Brand = dbCar.Brand,
                CarRegistrationNumber = dbCar.CarRegistrationNumber
            };
            return View(model: viewCar);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CarEditDto car)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbCar = _carRepo.GetById(id);
            if (dbCar == null)
            {
                return NotFound();
            }

            dbCar.Model = car.Model;
            dbCar.Brand = car.Brand;
            dbCar.CarRegistrationNumber = car.CarRegistrationNumber;
            _carRepo.Update(id, dbCar);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbCar = _carRepo.GetById(id);
            if (dbCar == null)
            {
                return NotFound();
            }

            var viewCar = new CarDeleteDto
            {
                CarRegistrationNumber = dbCar.CarRegistrationNumber,
                Model = dbCar.Model,
                Brand = dbCar.Brand
            };
            return View(model: viewCar);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _carRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
