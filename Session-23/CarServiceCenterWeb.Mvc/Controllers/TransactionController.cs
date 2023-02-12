using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenterWeb.Mvc.Models.Engineer;
using CarServiceCenterWeb.Mvc.Models.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenterWeb.Mvc.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Car> carRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Customer> customerRepo)
        {
            _transactionRepo = transactionRepo;
            _carRepo = carRepo;
            _managerRepo = managerRepo;
            _customerRepo = customerRepo;

        }
        // GET: TransactionController
        public ActionResult Index()
        {
            var transaction = _transactionRepo.GetAll();
            return View(model:transaction);
        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionController/Create
        public ActionResult Create()
        {
            var newTransaction = new TransactionCreateDto();
            var managers = _managerRepo.GetAll();
            var cars = _carRepo.GetAll();
            var customers = _customerRepo.GetAll();
            foreach (var manager in managers)
            {
                newTransaction.Manager.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Surname + " " + manager.Name, manager.Id.ToString()));
            }
            foreach (var customer in customers)
            {
                newTransaction.Customer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customer.Surname + " " + customer.Name, customer.Id.ToString()));
            }
            foreach (var car in cars)
            {
                newTransaction.Car.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(car.CarRegistrationNumber, car.Id.ToString()));
            }
            return View(model: newTransaction);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbTransaction = new Transaction(transaction.TotalPrice)
            {
                ManagerId = transaction.ManagerId,
                CarId= transaction.CarId,
                CustomerId= transaction.CustomerId,
            };

            _transactionRepo.Add(dbTransaction);
            return RedirectToAction("Index");
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null)
            {
                return NotFound();
            }

            var transactionDto = new TransactionEditDto
            {
                TotalPrice = dbTransaction.TotalPrice,
                CustomerId= dbTransaction.CustomerId,
                CarId =dbTransaction.CarId,
                ManagerId = dbTransaction.ManagerId,
                Id = dbTransaction.Id
            };

            var managers = _managerRepo.GetAll();
            foreach (var manager in managers)
            {
                transactionDto.Manager.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Name + " " + manager.Surname, manager.Id.ToString()));
            }
            var cars = _carRepo.GetAll();
            foreach (var car in cars)
            {
                transactionDto.Car.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(car.CarRegistrationNumber, car.Id.ToString()));
            }
            var customers = _customerRepo.GetAll();
            foreach (var customer in customers)
            {
                transactionDto.Customer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customer.Name + " " + customer.Surname, customer.Id.ToString()));
            }

            return View(transactionDto);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var dbTransaction = _transactionRepo.GetById(id);
                if (dbTransaction == null)
                {
                    return NotFound();
                }
                dbTransaction.TotalPrice = transaction.TotalPrice;
                dbTransaction.ManagerId = transaction.ManagerId;
                dbTransaction.CarId = transaction.CarId;
                dbTransaction.CustomerId = transaction.CustomerId;


                _transactionRepo.Update(id, dbTransaction);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null)
            {
                return NotFound();
            }
            var viewTransaction = new TransactionDeleteDto
            {
                TotalPrice = dbTransaction.TotalPrice,
                ManagerId = dbTransaction.ManagerId,
                CustomerId = dbTransaction.CustomerId,
                CarId = dbTransaction.CarId

            };
            return View(model: viewTransaction);
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
