using System.Data.Entity;

namespace PANCodingExercise.Data.Contracts
{
    public interface IDbContext
    {
        IDbSet<T> Set<T>() where T : BaseEntity;
        void SaveChanges();
    }
}
