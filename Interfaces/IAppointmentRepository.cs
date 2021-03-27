using Gabinet_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Interfaces
{
    public class IAppointmentRepository
    {
        IEnumerable<AppointmentModel> GetAppointmentModels { get; }

    }
}
