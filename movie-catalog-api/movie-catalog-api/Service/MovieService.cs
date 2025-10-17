using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_catalog_api.DBContext;
using movie_catalog_api.Entity;
using movie_catalog_api.Model;

namespace movie_catalog_api.Service
{
    public class MovieService : IMovieService
    {
        private readonly MovieCatalogContext _context;

        public MovieService(MovieCatalogContext context)
        {
            _context = context;
        }

        public string AddMovie(Movie movie)
        {
            try
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
            return movie.Id;
        }

        public List<Movie> GetAll()
        {
            var response = _context.Movies.ToList();

            return response;
        }

        public Movie GetMovie(string id)
        {
            var response = _context.Movies.Find(id);
            if (response == null)
            {
                return null;
            }
            return response;
        }
    }

    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie GetMovie(string id);
        string AddMovie(Movie movie);
    }
}