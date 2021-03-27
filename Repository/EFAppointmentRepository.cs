using Gabinet_v2.Interfaces;
using Gabinet_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Repository
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private ApplicationDbContext appointmentContext;
        public EFAppointmentRepository(ApplicationDbContext appointmentCtx)
        {
            appointmentContext = appointmentCtx;
        }
    }
}
