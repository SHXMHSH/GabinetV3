using Gabinet_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.ViewModels
{
    public class ViewVisit
    {
        public List<AppointmentModel> AppointmentsView { get; set; }
        public List<PatientModel> PatientsView { get; set; }
        public List<Doctor> DoctorsView { get; set; }
    }
}
