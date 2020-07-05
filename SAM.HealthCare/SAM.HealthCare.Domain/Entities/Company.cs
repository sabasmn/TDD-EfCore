using System;
using System.Collections.Generic;
using System.Text;

namespace SAM.HealthCare.Domain.Entities
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
