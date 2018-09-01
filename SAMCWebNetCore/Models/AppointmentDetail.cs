using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMCWebNetCore.Models
{
    public class AppointmentDetail
    {
        public string PetID { get; set; }
        public string PetName { get; set; }
        public DateTime PetDOB { get; set; }
        public string SexCode { get; set; }
        public string SexName { get; set; }
        public string AnimalTypeCode { get; set; }
        public string AnimalTypeName { get; set; }
        public string BreedCode { get; set; }
        public string BreedName { get; set; }
        public string StatusCode { get; set; }
        public string Statusname { get; set; }
        public string AppointmentDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
