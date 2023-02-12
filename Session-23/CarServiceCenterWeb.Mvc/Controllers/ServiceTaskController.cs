using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenterWeb.Mvc.Models.Car;
using CarServiceCenterWeb.Mvc.Models.ServiceTask;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenterWeb.Mvc.Controllers
{
    public class ServiceTaskController : Controller
    {
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
       
        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo)
        {
            _serviceTaskRepo = serviceTaskRepo;
           
        }
        // GET: ServiceTaskController
        public ActionResult Index()
        {
            var serviceTask = _serviceTaskRepo.GetAll().ToList();
            return View(model: serviceTask);
        }

        // GET: ServiceTaskController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var serviceTask = _serviceTaskRepo.GetById(id.Value);
            if (serviceTask == null)
            {
                return NotFound();
            }
            var viewServiceTask = new ServiceTaskDetailsDto
            {
                Code = serviceTask.Code,
                Description = serviceTask.Description,
                Hours= serviceTask.Hours
            };

            return View(model: viewServiceTask);
        }

        // GET: ServiceTaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceTaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceTaskCreateDto serviceTask)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbServiceTask = new ServiceTask(serviceTask.Code,serviceTask.Description,serviceTask.Hours);
           
            _serviceTaskRepo.Add(dbServiceTask);
            return RedirectToAction("Index");
        }

        // GET: ServiceTaskController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbServiceTask = _serviceTaskRepo.GetById(id);
            if (dbServiceTask == null)
            {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskEditDto
            {
                Code= dbServiceTask.Code,
                Description= dbServiceTask.Description,
                Hours= dbServiceTask.Hours
            };
            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ServiceTaskEditDto serviceTask)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbServiceTask = _serviceTaskRepo.GetById(id);
            if (dbServiceTask == null)
            {
                return NotFound();
            }

            dbServiceTask.Hours = serviceTask.Hours;
            dbServiceTask.Code = serviceTask.Code;
            dbServiceTask.Description = serviceTask.Description;
            _serviceTaskRepo.Update(id, dbServiceTask);
            return RedirectToAction(nameof(Index));
        }

        // GET: ServiceTaskController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbServiceTask = _serviceTaskRepo.GetById(id);
            if (dbServiceTask == null)
            {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskDeleteDto
            {
                Hours= dbServiceTask.Hours,
                Code= dbServiceTask.Code,
                Description= dbServiceTask.Description
            };
            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _serviceTaskRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
