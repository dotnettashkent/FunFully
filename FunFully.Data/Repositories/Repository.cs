using FunFully.Data.Contexts;
using FunFully.Data.IRepositories;
using FunFully.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace FunFully.Data.Repositories
{
#pragma warning disable
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly AppDbContext appDbContext;
        private readonly DbSet<TEntity> dbSet;

        public Repository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.dbSet = appDbContext.Set<TEntity>();
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            var result = await dbSet.AddAsync(entity);
            return result.Entity;
        }

        public async Task<TEntity> GetAsync(long id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var result = dbSet.Update(entity);
            return result.Entity;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            dbSet.Remove(entity);
            return true;
        }
    }

}
