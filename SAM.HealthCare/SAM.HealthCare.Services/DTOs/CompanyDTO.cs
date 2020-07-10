namespace SAM.HealthCare.Services.DTOs
{
    public class CompanyDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public CompanyDto()
        {
            
        }

        public CompanyDto(int id, string name, string phoneNumber, string address)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
