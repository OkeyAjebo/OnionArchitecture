using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IMovieRepository<T>
    {
        IEnumerable<T> GetMovies();
        IQueryable<T> FindBy(Expression<Func<Movie, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        T GetSingle(int id);
        void Save();
    }
}
