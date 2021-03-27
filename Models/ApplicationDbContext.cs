using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<AppointmentModel> Appointments { get; set; }
        public DbSet<AssistantModel> Assistants { get; set; }
    }
}
