using Gabinet_v2.Models;
using Gabinet_v2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Interfaces
{
    public interface IAdminRepository
    {
        IEnumerable<Doctor> Doctors { get; }
        void EditDoctor(Doctor model);
        void SaveDoctor(Doctor model);
        Doctor DeleteDoctor(int DoctorID);

        IEnumerable<PatientModel> Patients { get; }
        void EditPatient(PatientModel patientModel);
        void SavePatient(PatientModel patientModel);
        PatientModel DeletePatient(int PatientModel);

        IEnumerable<AssistantModel> Assistants { get; }
        void EditAssistant(AssistantModel AssistantModel);
        void SaveAssistant(AssistantModel AssistantModel);
        AssistantModel DeleteAssistant(int AssistantModel);

        IEnumerable<AppointmentModel> Appointments { get; }
        void EditAppointment(AppointmentModel AppointmentModel);
        void SaveAppointment(AppointmentModel AppointmentModel);
        AppointmentModel DeleteAppointment(int AppointmentModel);

        IQueryable<ViewVisit> ViewVisits { get; }

        List<AppointmentModel> ViewVisits();
    }
}
