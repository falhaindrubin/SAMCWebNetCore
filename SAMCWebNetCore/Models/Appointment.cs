﻿using System;
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
        public string PetID { get; set; }
        public string PetName { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string AppointmentDesc { get; set; }
        public string CreatedBy { get; set; }
        public string DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public string DateModified { get; set; }
    }
}