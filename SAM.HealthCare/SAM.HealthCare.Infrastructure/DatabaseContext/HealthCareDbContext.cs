using Microsoft.EntityFrameworkCore;
using SAM.HealthCare.Domain.Base;
using SAM.HealthCare.Domain.Entities;

namespace SAM.HealthCare.Infrastructure.DatabaseContext
{
    public class HealthCareDbContext: DbContext, IUnitOfWork
    {
        public HealthCareDbContext(DbContextOptions<HealthCareDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public void Commit()
        {
            this.SaveChanges();
        }
    }
}
