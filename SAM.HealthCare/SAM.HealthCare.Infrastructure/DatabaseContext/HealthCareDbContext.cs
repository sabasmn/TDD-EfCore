using Microsoft.EntityFrameworkCore;

namespace SAM.HealthCare.Infrastructure.DatabaseContext
{
    public class HealthCareDbContext: DbContext
    {
        public HealthCareDbContext(DbContextOptions<HealthCareDbContext> options) : base(options)
        {

        }
    }
}
