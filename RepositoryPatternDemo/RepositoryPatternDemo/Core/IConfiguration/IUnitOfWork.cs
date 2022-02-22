using RepositoryPatternDemo.Core.IRepositories;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IUserRepository User{get;}
        Task CompleteAsync();
    }
}
