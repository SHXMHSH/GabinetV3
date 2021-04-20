using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gabinet_v2.Models
{
    public class AppointmentModel
    {
        [Key]
        public int Id { get; set; }
        public string AppointmentDate { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public PatientModel Patient { get; set; }
        public Doctor Doctor { get; set; }

    }
}
