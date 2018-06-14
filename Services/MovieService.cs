using Domain.Entities;
using Infrastructure.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Services
{
    public class MovieService : IMovieService<Movie>
    {
        private readonly MovieRepository _repository;

        public MovieService()
        {
            _repository = new MovieRepository();

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
            return _repository.GetMovies();
        }

        public Movie GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Movie> GetMovies()
        //{
        //    return _repository.GetMovies();
        //}
    }
}
