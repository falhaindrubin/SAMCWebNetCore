using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMCWebNetCore.Models
{
    public class Appointment
    {
        public string AppointmentID { get; set; }
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
