using Gabinet_v2.Interfaces;
using Gabinet_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Repository
{
    public class EFAdminRepository : IAdminRepository
    {
        private ApplicationDbContext adminContext;
        public EFAdminRepository(ApplicationDbContext admCtx)
        {
            adminContext = admCtx;
        }

        public IQueryable<Doctor> Doctors => adminContext.Doctors;

        public void EditDoctor(Doctor doctor)
        {
            adminContext.Doctors.Update(doctor);
            adminContext.SaveChanges();
        }

        public Doctor DeleteDoctor(int DoctorID)
        {
            Doctor dbEntry = adminContext.Doctors.FirstOrDefault(p => p.Id == DoctorID);
            if (dbEntry != null)
            {
                adminContext.Doctors.Remove(dbEntry);
                adminContext.SaveChanges();
            }
            return dbEntry;
        }
        public void SaveDoctor(Doctor doctor)
        {
            if (doctor.Id == 0)
            {
                adminContext.Doctors.Add(doctor);

            }
            else
            {
                Doctor dbEntry = adminContext.Doctors.FirstOrDefault(p => p.Id == doctor.Id);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = doctor.FirstName;
                    dbEntry.LastName = doctor.LastName;
                }
            }
            adminContext.SaveChanges();
        }

        //------ Patient

        public IQueryable<PatientModel> Patients => adminContext.Patients;

        public void EditPatient(PatientModel patient)
        {
            adminContext.Patients.Update(patient);
            adminContext.SaveChanges();
        }

        public PatientModel DeletePatient(int PatientID)
        {
            PatientModel dbEntry = adminContext.Patients.FirstOrDefault(p => p.Id == PatientID);
            if (dbEntry != null)
            {
                adminContext.Patients.Remove(dbEntry);
                adminContext.SaveChanges();
            }
            return dbEntry;
        }
        public void SavePatient(PatientModel patient)
        {
            if (patient.Id == 0)
            {
                adminContext.Patients.Add(patient);

            }
            else
            {
                PatientModel dbEntry = adminContext.Patients.FirstOrDefault(p => p.Id == patient.Id);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = patient.FirstName;
                    dbEntry.LastName = patient.LastName;
                    dbEntry.PESEL = patient.PESEL;
                }
            }
            adminContext.SaveChanges();
        }

        //------ appointment

        public IQueryable<AppointmentModel> Appointments => adminContext.Appointments;

        public void EditAppointment(AppointmentModel appointment)
        {
            adminContext.Appointments.Update(appointment);
            adminContext.SaveChanges();
        }

        public AppointmentModel DeleteAppointment(int AppointmentID)
        {
            AppointmentModel dbEntry = adminContext.Appointments.FirstOrDefault(p => p.Id == AppointmentID);
            if (dbEntry != null)
            {
                adminContext.Appointments.Remove(dbEntry);
                adminContext.SaveChanges();
            }
            return dbEntry;
        }
        public void SaveAppointment(AppointmentModel appointment)
        {
            if (appointment.Id == 0)
            {
                adminContext.Appointments.Add(appointment);

            }
            else
            {
                AppointmentModel dbEntry = adminContext.Appointments.FirstOrDefault(p => p.Id == appointment.Id);
                if (dbEntry != null)
                {
                    dbEntry.AppointmentDate = appointment.AppointmentDate;
                    dbEntry.Description = appointment.Description;
                    dbEntry.DoctorId = appointment.DoctorId;
                    dbEntry.PatientId = appointment.PatientId;
                    dbEntry.Price = appointment.Price;
                }
            }
            adminContext.SaveChanges();
        }

        //------ assistant

        public IQueryable<AssistantModel> Assistants => adminContext.Assistants;

        public void EditAssistant(AssistantModel assistant)
        {
            adminContext.Assistants.Update(assistant);
            adminContext.SaveChanges();
        }

        public AssistantModel DeleteAssistant(int AssistantID)
        {
            AssistantModel dbEntry = adminContext.Assistants.FirstOrDefault(p => p.Id == AssistantID);
            if (dbEntry != null)
            {
                adminContext.Assistants.Remove(dbEntry);
                adminContext.SaveChanges();
            }
            return dbEntry;
        }
        public void SaveAssistant(AssistantModel assistant)
        {
            if (assistant.Id == 0)
            {
                adminContext.Assistants.Add(assistant);

            }
            else
            {
                AssistantModel dbEntry = adminContext.Assistants.FirstOrDefault(p => p.Id == assistant.Id);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = assistant.FirstName;
                    dbEntry.LastName = assistant.LastName;
                }
            }
            adminContext.SaveChanges();
        }

    }
}
