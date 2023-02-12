﻿using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenterWeb.Mvc.Models.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenterWeb.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo= customerRepo;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            //check
            var customers = _customerRepo.GetAll().ToList();
            return View(model:customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int? id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var customer = _customerRepo.GetById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }
            var viewCustomer = new CustomerDetailsDto
            {
                Name = customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone,
                Tin = customer.Tin
            };
            return View(model:viewCustomer) ;
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCustomer = new Customer(customer.Name, customer.Surname, customer.Phone, customer.Tin);
            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index");

        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }

            var viewCustomer = new CustomerEditDto
            {
                Name= dbCustomer.Name,
                Surname= dbCustomer.Surname,
                Phone= dbCustomer.Phone,
                Tin= dbCustomer.Tin
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Tin = customer.Tin;
            _customerRepo.Update(id,dbCustomer);
            return RedirectToAction(nameof(Index));
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }

            var viewCustomer = new CustomerDeleteDto
            {
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin
            };
            return View(model: viewCustomer); 
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _customerRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
