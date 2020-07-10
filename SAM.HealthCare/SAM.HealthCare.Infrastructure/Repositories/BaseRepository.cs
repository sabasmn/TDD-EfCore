using Microsoft.EntityFrameworkCore;
using SAM.HealthCare.Domain.Base;
using SAM.HealthCare.Infrastructure.DatabaseContext;

namespace SAM.HealthCare.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository where T : Entity
    {
        public BaseRepository(HealthCareDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }

        public HealthCareDbContext DbContext { get; private set; }
        public IUnitOfWork UnitOfWork => this.DbContext;
        public DbSet<T> DbSet { get; set; }
    }
}
