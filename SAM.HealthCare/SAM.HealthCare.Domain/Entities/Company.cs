using SAM.HealthCare.Domain.Base;

namespace SAM.HealthCare.Domain.Entities
{
    public class Company : Entity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
