
using Gabinet_v2.Interfaces;
using Gabinet_v2.Models;
using Gabinet_v2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Controllers
{
    public class AdminController : Controller
    {
        private IAdminRepository adminRepository;
        //----------- Admin
        public AdminController(IAdminRepository adminRepo)
        {
            adminRepository = adminRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoctorIndex()
        {
            return View(adminRepository.Doctors);
        }

        public ViewResult EditDoctor(int DoctorID) => View(adminRepository.Doctors.FirstOrDefault(p => p.Id == DoctorID));
        [HttpPost]
        public IActionResult EditDoctor(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                adminRepository.SaveDoctor(doctor);
                return RedirectToAction(nameof(DoctorIndex));
            }
            else
            {
                return View(doctor);
            }
        }

        public ViewResult CreateDoctor() => View("EditDoctor", new Doctor());
        [HttpPost]
        public IActionResult DeleteDoctor(int DoctorID)
        {
            Doctor deletedDoctor = adminRepository.DeleteDoctor(DoctorID);
            if (deletedDoctor != null)
            {
                TempData["message"] = $"Deleted succesfully {deletedDoctor.LastName}.";
            }
            return RedirectToAction(nameof(DoctorIndex));
        }
        //----------- Patient

        public IActionResult PatientIndex()
        {
            return View(adminRepository.Patients);
        }

        public ViewResult EditPatient(int PatientID) => View(adminRepository.Patients.FirstOrDefault(p => p.Id == PatientID));
        [HttpPost]
        public IActionResult EditPatient(PatientModel patient)
        {
            if (ModelState.IsValid)
            {
                adminRepository.SavePatient(patient);
                return RedirectToAction(nameof(PatientIndex));
            }
            else
            {
                return View(patient);
            }
        }

        public ViewResult CreatePatient() => View("EditPatient", new PatientModel());
        [HttpPost]
        public IActionResult DeletePatient(int PatientID)
        {
            PatientModel deletedPatient = adminRepository.DeletePatient(PatientID);
            if (deletedPatient != null)
            {
                TempData["message"] = $"Deleted succesfully {deletedPatient.LastName}.";
            }
            return RedirectToAction(nameof(PatientIndex));
        }

        //----------- Appointment
        //public IActionResult AppointmentIndex()
        //{
        //    return View(adminRepository.Appointments);
        //}

        public async Task<IActionResult> AppointmentIndex()
        {
            var appointments = adminRepository.Appointments
                .Include(c => c.Patient)
                .Include(c => c.Doctor)
                .AsNoTracking();
            return View(await appointments.ToListAsync());
        }
        public ViewResult EditAppointment(int AppointmentID) => View(adminRepository.Appointments.FirstOrDefault(p => p.Id == AppointmentID));
        [HttpPost]
        public IActionResult EditAppointment(AppointmentModel appointment)
        {
            if (ModelState.IsValid)
            {
                adminRepository.SaveAppointment(appointment);
                return RedirectToAction(nameof(AppointmentIndex));
            }
            else
            {
                return View(appointment);
            }
        }

        public ViewResult CreateAppointment() => View("EditAppointment", new AppointmentModel());
        [HttpPost]
        public IActionResult DeleteAppointment(int AppointmentID)
        {
            AppointmentModel deletedAppointment = adminRepository.DeleteAppointment(AppointmentID);
            if (deletedAppointment != null)
            {
                TempData["message"] = $"Deleted succesfully {deletedAppointment.AppointmentDate}.";
            }
            return RedirectToAction(nameof(AppointmentIndex));
        }



        //------Assistant
        public IActionResult AssistantIndex()
        {
            return View(adminRepository.Assistants);
        }

        public ViewResult EditAssistant(int AssistantID) => View(adminRepository.Assistants.FirstOrDefault(p => p.Id == AssistantID));
        [HttpPost]
        public IActionResult EditAssistant(AssistantModel assistant)
        {
            if (ModelState.IsValid)
            {
                adminRepository.SaveAssistant(assistant);
                return RedirectToAction(nameof(AssistantIndex));
            }
            else
            {
                return View(assistant);
            }
        }

        public ViewResult CreateAssistant() => View("EditAssistant", new AssistantModel());
        [HttpPost]
        public IActionResult DeleteAssistant(int AssistantID)
        {
            AssistantModel deletedAssistant = adminRepository.DeleteAssistant(AssistantID);
            if (deletedAssistant != null)
            {
                TempData["message"] = $"Deleted succesfully {deletedAssistant.LastName}.";
            }
            return RedirectToAction(nameof(AssistantIndex));
        }



    }

}