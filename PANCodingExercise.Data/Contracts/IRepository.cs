using System.Linq;

namespace PANCodingExercise.Data.Contracts
{
    /// <summary>
    /// We need to be able to get, save, edit from the requirement
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial interface IRepository<T> where T : BaseEntity
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        IQueryable<T> Table { get; }
    }
}
