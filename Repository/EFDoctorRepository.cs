using Gabinet_v2.Interfaces;
using Gabinet_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Repository
{
    public class EFDoctorRepository : IDoctorRepository
    {
        private ApplicationDbContext context;
        public EFDoctorRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Doctor> Doctors => context.Doctors;

        public void EditDoctor(Doctor doctor)
        {
            context.Doctors.Update(doctor);
            context.SaveChanges();
        }

        public Doctor DeleteDoctor(int DoctorID)
        {
            Doctor dbEntry = context.Doctors.FirstOrDefault(p => p.Id == DoctorID);
            if (dbEntry != null)
            {
                context.Doctors.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveDoctor(Doctor doctor)
        {
            if (doctor.Id == 0)
            {
                context.Doctors.Add(doctor);

            }
            else
            {
                Doctor dbEntry = context.Doctors.FirstOrDefault(p => p.Id == doctor.Id);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = doctor.FirstName;
                    dbEntry.LastName = doctor.LastName;
                }
            }
            context.SaveChanges();
        }
    }
}
