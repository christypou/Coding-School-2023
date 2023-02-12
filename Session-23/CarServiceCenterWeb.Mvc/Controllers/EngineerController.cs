using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenterWeb.Mvc.Models.Engineer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenterWeb.Mvc.Controllers
{
    public class EngineerController : Controller
    {
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        public EngineerController(IEntityRepo<Manager> managerRepo, IEntityRepo<Engineer> EngineerRepo)
        {
            _managerRepo = managerRepo;
            _engineerRepo = EngineerRepo;
            
        }
        // GET: EngineerController
        public ActionResult Index()
        {
            var engineer = _engineerRepo.GetAll();
            return View(model :engineer);
        }

        // GET: EngineerController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var engineers = _engineerRepo.GetById(id.Value);
            var manager = _managerRepo.GetById(engineers.ManagerId);
            if (engineers == null)
            {
                return NotFound();
            }
            var engineerDto = new EngineerDetailsDto
            {
                Name = engineers.Name,
                Surname = engineers.Surname,
                SalaryPerMonth = engineers.SalaryPerMonth,
                ManagerID = engineers.ManagerId,
                Id =engineers.Id
            };
            engineerDto.Manager.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Name + " " + manager.Surname, manager.Id.ToString()));
            return View(model :engineerDto);
        }

        // GET: EngineerController/Create
        public ActionResult Create()
        {
            var newEngineer = new EngineerCreateDto();
            var managers = _managerRepo.GetAll();
            foreach(var manager in managers)
            {
                newEngineer.Manager.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Name + " " + manager.Surname, manager.Id.ToString()));
            }
            return View(model:newEngineer);
        }

        // POST: EngineerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EngineerCreateDto engineer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbEngineer = new Engineer(engineer.Name, engineer.Surname, engineer.SalaryPerMonth)
            {
                ManagerId = engineer.ManagerID
            };

            _engineerRepo.Add(dbEngineer);
            return RedirectToAction("Index");
        }

        // GET: EngineerController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbEngineer = _engineerRepo.GetById(id);
            if (dbEngineer == null)
            {
                return NotFound();
            }

            var engineerDto = new EngineerEditDto
            {
                Name= dbEngineer.Name,
                Surname= dbEngineer.Surname,
                SalaryPerMonth= dbEngineer.SalaryPerMonth,
                ManagerID = dbEngineer.ManagerId,
                Id= dbEngineer.Id
            };

            var managers = _managerRepo.GetAll();
            foreach (var manager in managers)
            {
                engineerDto.Manager.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Name + " " +manager.Surname, manager.Id.ToString()));
            }

            return View(engineerDto);
        }

        // POST: EngineerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EngineerEditDto engineer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var dbEngineer = _engineerRepo.GetById(id);
                if (dbEngineer == null)
                {
                    return NotFound();
                }
                dbEngineer.Surname = engineer.Surname;
                dbEngineer.Name = engineer.Name;
                dbEngineer.SalaryPerMonth= engineer.SalaryPerMonth;
                dbEngineer.ManagerId = engineer.ManagerID;
                

                _engineerRepo.Update(id, dbEngineer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EngineerController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbengineer = _engineerRepo.GetById(id); 
            if (dbengineer == null)
            {
                return NotFound();
            }
            var viewEngineer = new EngineerDeleteDto { 
            Name= dbengineer.Name,
            Surname = dbengineer.Surname,
            SalaryPerMonth = dbengineer.SalaryPerMonth,
            ManagerID = dbengineer.ManagerId,
            
            };
            return View(model: viewEngineer);
        }

        // POST: EngineerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _engineerRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
