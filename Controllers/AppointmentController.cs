using Gabinet_v2.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Controllers
{
    public class AppointmentController : Controller
    {
        private IAppointmentRepository appointmentRepository;
        
        public AppointmentController(IAppointmentRepository appointmentRepo)
        {
            appointmentRepository = appointmentRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
