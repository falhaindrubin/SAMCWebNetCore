using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMCWebNetCore.Models
{
    public class Customer
    {        
        public string CustomerID { get; set; }
        public string SaluteCode { get; set; }
        public string SaluteName { get; set; }
        public string CustomerName { get; set; }
        public string NRICPassportNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string TelNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }        
    }
}


