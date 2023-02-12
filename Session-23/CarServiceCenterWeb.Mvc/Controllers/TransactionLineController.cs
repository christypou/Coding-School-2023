using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenterWeb.Mvc.Models.ServiceTask;
using CarServiceCenterWeb.Mvc.Models.Transaction;
using CarServiceCenterWeb.Mvc.Models.TransactionLines;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenterWeb.Mvc.Controllers
{
    public class TransactionLineController : Controller
    {
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo)
        {
            _transactionLineRepo = transactionLineRepo;
            _transactionRepo = transactionRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;

        }
        // GET: TransactionLineController
        public ActionResult Index()
        {
            var transactionLine = _transactionLineRepo.GetAll();
            return View(model: transactionLine);
        }

        // GET: TransactionLineController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var transactionLine = _transactionLineRepo.GetById(id.Value);
            var transaction = _transactionRepo.GetById(transactionLine.TransactionId);
            var serviceTask = _serviceTaskRepo.GetById(transactionLine.ServiceTaskId);
            var engineer = _engineerRepo.GetById(transactionLine.EngineerId);
            if (transactionLine == null)
            {
                return NotFound();
            }
            var transactionLineDto = new TransactionLinesDetailsDto
            {
                Hours = transactionLine.Hours,
                PricePerHour = transactionLine.PricePerHour,
                Price = transactionLine.Price,
                TransactionId = transactionLine.TransactionId,
                ServiceTaskId = transactionLine.ServiceTaskId,
                EngineerId = transactionLine.EngineerId,
                Id = transactionLine.Id
            };
            transactionLineDto.Transaction.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(transaction.Date.ToString(), transaction.Id.ToString()));
            transactionLineDto.ServiceTask.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(serviceTask.Code, serviceTask.Id.ToString()));
            transactionLineDto.Engineer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(engineer.Name + " " + engineer.Surname, engineer.Id.ToString()));
            return View(model: transactionLineDto);
        }

        // GET: TransactionLineController/Create
        public ActionResult Create()
        {
            var newTransactionLine = new TransactionLinesCreateDto();
            var transactions = _transactionRepo.GetAll();
            var serviceTasks = _serviceTaskRepo.GetAll();
            var engineers = _engineerRepo.GetAll();
            foreach (var transaction in transactions)
            {
                newTransactionLine.Transaction.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(transaction.Date.ToString(), transaction.Id.ToString()));
            }
            foreach (var serviceTask in serviceTasks)
            {
                newTransactionLine.ServiceTask.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(serviceTask.Code, serviceTask.Id.ToString()));
            }
            foreach (var engineer in engineers)
            {
                newTransactionLine.Engineer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(engineer.Name +" "+engineer.Surname, engineer.Id.ToString()));
            }
            return View(model: newTransactionLine);
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionLinesCreateDto transactionLine)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbTransactionLine = new TransactionLine(transactionLine.Hours)
            {
                TransactionId = transactionLine.TransactionId,
                ServiceTaskId = transactionLine.ServiceTaskId,
                EngineerId = transactionLine.EngineerId
                
            };

            _transactionLineRepo.Add(dbTransactionLine);
            return RedirectToAction("Index");
        }

        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null)
            {
                return NotFound();
            }

            var transactionLineDto = new TransactionLinesEditDto
            {
                Hours= dbTransactionLine.Hours,
                PricePerHour= dbTransactionLine.PricePerHour,
                Price= dbTransactionLine.Price,
                EngineerId = dbTransactionLine.EngineerId,
                TransactionId = dbTransactionLine.TransactionId,
                ServiceTaskId = dbTransactionLine.ServiceTaskId,
                Id = dbTransactionLine.Id
            };

            var engineers = _engineerRepo.GetAll();
            foreach (var engineer in engineers)
            {
                transactionLineDto.Engineer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(engineer.Name + " " + engineer.Surname, engineer.Id.ToString()));
            }
            var transactions = _transactionRepo.GetAll();
            foreach (var transaction in transactions)
            {
                transactionLineDto.Transaction.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(transaction.Date.ToString(), transaction.Id.ToString()));
            }
            var serviceTasks = _serviceTaskRepo.GetAll();
            foreach (var serviceTask in serviceTasks)
            {
                transactionLineDto.ServiceTask.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(serviceTask.Code, serviceTask.Id.ToString()));
            }

            return View(transactionLineDto);
        }

        // POST: TransactionLineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionLinesEditDto transactionLine)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var dbTransactionLine = _transactionLineRepo.GetById(id);
                if (dbTransactionLine == null)
                {
                    return NotFound();
                }
                dbTransactionLine.Hours = transactionLine.Hours;
                dbTransactionLine.Price = transactionLine.Price;
                dbTransactionLine.PricePerHour = transactionLine.PricePerHour;
                dbTransactionLine.TransactionId = transactionLine.TransactionId;
                dbTransactionLine.EngineerId = transactionLine.EngineerId;
                dbTransactionLine.ServiceTaskId = transactionLine.ServiceTaskId;


                _transactionLineRepo.Update(id, dbTransactionLine);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null)
            {
                return NotFound();
            }
            var viewTransactionLine = new TransactionLinesDeleteDto
            {
                Price = dbTransactionLine.Price,
                PricePerHour = dbTransactionLine.PricePerHour,
                Hours = dbTransactionLine.Hours,
                EngineerId = dbTransactionLine.EngineerId,
                ServiceTaskId = dbTransactionLine.ServiceTaskId,
                TransactionId = dbTransactionLine.TransactionId

            };
            return View(model: viewTransactionLine);
        }

        // POST: TransactionLineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _transactionLineRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
