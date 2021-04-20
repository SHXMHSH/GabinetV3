using Gabinet_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Interfaces
{
    public interface IDoctorRepository
    {
        IQueryable<Doctor> Doctors { get; }
        void EditDoctor(Doctor model);
        void SaveDoctor(Doctor model);
        Doctor DeleteDoctor(int DoctorID);
    }
}
