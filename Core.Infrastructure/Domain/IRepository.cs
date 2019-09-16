using Core.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Infrastructure.Domain
{
    public interface IRepository<T, TId> : IUnitOfWork
    {
        IQueryable<T> GetAll();
        Task<T> GetById(TId id);
        Task Create(T entity);
        void Update(T entity);

        void Delete(T instance);
        void Delete(IEnumerable<T> collectionToDelete);
    }
}
