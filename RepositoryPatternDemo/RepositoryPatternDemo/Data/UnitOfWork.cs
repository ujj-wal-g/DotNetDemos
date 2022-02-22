﻿using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Core.IConfiguration;
using RepositoryPatternDemo.Core.IRepositories;
using RepositoryPatternDemo.Core.Repositories;

namespace RepositoryPatternDemo.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
       public IUserRepository User {get;private set;}

        
        public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");
            User = new UserRepository(_context, _logger);
        }
        public async Task CompleteAsync()
        {
             await _context.SaveChangesAsync();
        }
        public void  Dispose()
        {
           _context.Dispose();
        }
    }
}
