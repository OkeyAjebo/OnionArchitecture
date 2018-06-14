using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Data
{
    public class MovieRepository : IMovieRepository<Movie>
    {
        private readonly MovieDbContext context;

        public MovieRepository()
        {
            context = new MovieDbContext();
        }

        public void Add(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Movie entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Movie> FindBy(Expression<Func<Movie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }

        public Movie GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
