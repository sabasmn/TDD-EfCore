namespace SAM.HealthCare.Domain.Base
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}