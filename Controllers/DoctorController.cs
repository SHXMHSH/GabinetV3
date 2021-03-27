using Gabinet_v2.Interfaces;
using Gabinet_v2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Controllers
{
    public class DoctorController : Controller
    {

        private IDoctorRepository repository;

        public DoctorController(IDoctorRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index() => View(repository.Doctors);

        public IActionResult Index()
        {
            return View(repository.Doctors);
        }
        public ViewResult Edit(int DoctorID) => View(repository.Doctors.FirstOrDefault(p => p.Id == DoctorID));

        [HttpPost]
        public IActionResult Edit(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDoctor(doctor);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(doctor);
            }
        }
        public ViewResult Create() => View("Edit", new Doctor());
        [HttpPost]
        public IActionResult Delete(int DoctorID)
        {
            Doctor deletedDoctor = repository.DeleteDoctor(DoctorID);
            if (deletedDoctor != null)
            {
                TempData["message"] = $"Deleted succesfully {deletedDoctor.LastName}.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
