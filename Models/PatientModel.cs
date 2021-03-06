using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Models
{
    public class PatientModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(11)]
        [MinLength(11)]
        public string PESEL { get; set; }
    }
}
