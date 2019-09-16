using Core.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Infrastructure.Domain
{
    public interface IRepository<T, TId> : IUnitOfWork
    {
        //T CreateNew();
        //T Get(TId id);
        //IQueryable<T> GetAll();
        ////IQueryable<T> GetAll(Query query);
        ////IQueryable<T> GetAll(Query query, int pageNumber, int pageSize);
        //void Add(T instance);
        //void Attach(T instance);
        //void Delete(T instance);
        //void Delete(IEnumerable<T> collectionOfItemsToDelete);

        IQueryable<T> GetAll();
        Task<T> GetById(TId id);
        Task Create(T entity);
        void Update(T entity);

        void Delete(T instance);
        void Delete(IEnumerable<T> collectionToDelete);
    }
}
