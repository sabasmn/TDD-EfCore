using Microsoft.EntityFrameworkCore;
using SAM.HealthCare.Domain.Entities;

namespace SAM.HealthCare.Infrastructure.DatabaseContext
{
    public class HealthCareDbContext: DbContext
    {
        public HealthCareDbContext(DbContextOptions<HealthCareDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
    }
}
