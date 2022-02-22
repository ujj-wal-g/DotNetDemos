using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Core.IRepositories;
using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Models;
using System.Collections;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Core.Repositories
{
    public class UserRepository : GenericRepository<Users>,IUserRepository
    {
        public UserRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        } 
        public async override Task<IEnumerable<Users>>All()
        {
            try
            {
                return await dbset.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"{Repo}All method error",typeof(UserRepository));
                return new List<Users>();    
            }
        }
        public override async Task<bool> Upsert(Users entity)
        {
            try 
            {
                var existingUser = await dbset.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
                if (existingUser == null)
                    return await Add(entity);
                existingUser.FirstName = entity.FirstName;
                existingUser.LastName = entity.LastName;
                existingUser.Email = entity.Email;
                return true;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Repo}Upsert method error", typeof(UserRepository));
                return false;
            }
        }
        public override async Task<bool> Delete(Guid id)
        {
            try
            {
                var existigUser= await dbset.Where(x=>x.Id == id).FirstOrDefaultAsync();
                if(existigUser != null)
                {
                     dbset.Remove(existigUser);
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Repo}Delete method error", typeof(UserRepository));
                return false;
            }
        }
        
    }
}
