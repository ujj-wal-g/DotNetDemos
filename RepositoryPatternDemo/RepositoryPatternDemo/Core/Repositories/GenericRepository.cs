using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Core.IRepositories;
using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Core.Repositories
{
    public class GenericRepository<T> : IGenricRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> dbset;

        protected readonly ILogger _logger;
        public GenericRepository(ApplicationDbContext context,ILogger logger)
        {
            _context= context;
            _logger= logger;
            this.dbset= context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await dbset.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
           return await dbset.FindAsync(id);
        }

        public virtual  async Task<bool> Add(T entity)
        {
            await dbset.AddAsync(entity);
            return true;
        }

        public virtual  Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
