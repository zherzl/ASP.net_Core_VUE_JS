using Core.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.EF.Repositories
{
    public abstract class RepositoryBase<T, TId> : IRepository<T, TId> where T : class, IEntityBase<TId>
    {
        private readonly GalleryContext ctx;

        public RepositoryBase(GalleryContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task Create(T entity)
        {
            await ctx.Set<T>().AddAsync(entity);
        }

        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>().AsNoTracking();
        }


        public async Task<T> GetById(TId id)
        {
            return await ctx
                .Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public void ResetCurrentContext()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            ctx.Set<T>().Update(entity);
        }

        public void Delete(T instance)
        {
            var entity = ctx.Remove(instance);
        }

        public void Delete(IEnumerable<T> collectionToDelete)
        {
            var delete = new List<T>();
            delete.AddRange(collectionToDelete);

            foreach (var item in delete)
            {
                this.Delete(item);
            }
        }

        public async void SaveChanges()
        {
            await ctx.SaveChangesAsync();
        }

    }
}
