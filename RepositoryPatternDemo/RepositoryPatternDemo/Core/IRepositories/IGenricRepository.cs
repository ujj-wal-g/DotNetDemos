﻿namespace RepositoryPatternDemo.Core.IRepositories
{
    public interface IGenricRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById( Guid id);
        Task<bool>Add(T entity);
        Task<bool>Upsert(T entity);
        Task<bool> Delete( Guid id);

    }
}
