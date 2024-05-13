using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHP_Ls04.Models
{
    public class NHPCustomer
    {
        public string CustomerID { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string YearOfBirth { get; set; }

    }
}