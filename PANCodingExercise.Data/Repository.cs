using PANCodingExercise.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANCodingExercise.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _dbContext;
        private IDbSet<T> _entities;

        public Repository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T entity)
        {
            this.Entities.Add(entity);
            this._dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            this._dbContext.SaveChanges();
        }

        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = this._dbContext.Set<T>();
                return this._entities;
            }
        }
    }
}
