using System.Collections.Generic;
using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.Services
{
    public class MovieService
    {
        private readonly ICollection<Movie> _allMovies;
        private readonly MovieDB _movieDb;

        public MovieService()
        {
            _movieDb = new MovieDB();
            _allMovies = _movieDb.GetMovies();
        }

        public Movie GetMovieById(int id)
        {
            return _movieDb.GetMovie(id);
        }

        public Movie GetMovieByTitle(string title)
        {
            return _allMovies.First(x => x.MovieTitle == title);
        }

        public ICollection<Movie> GetMoviesLike(string search)
        {
            return _allMovies.Where(x => x.MovieTitle.Contains(search)).ToList();
        }

        public bool AddMovie(Movie movie)
        {
            return _movieDb.AddMovie(movie);
        }
    }
 }