using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.Exceptions;

namespace MeramecNetFlixProject.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class MovieDB : AccessDataSQLServer
    {
        public List<Movie> GetMovies()
        {
            const string sqlStatement = @"Select * from Movie";
            using (var com = new SqlCommand(sqlStatement))
            {
                var rawData = GetQuery(com);
                var movies = new List<Movie>();
                foreach (var item in rawData)
                {
                    var movie = MapMovie(item);
                    movies.Add(movie);
                }
                return movies;
            }
        }

        public Movie GetMovie(int id)
        {
            var sqlStatement = "Select * from Movie where id = @id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                var rawData = GetQuery(com);
                if (rawData.Count < 1)
                {
                    throw new NotFoundException("Movie not found");
                }
                var item = rawData.First();
                return MapMovie(item);
            }
        }

        public bool AddMovie(Movie movie)
        {
            const string sqlStatement = "Insert into Movie (movie_title, description, movie_year_made, genre_id, movie_rating, media_type, movie_retail_cost, copies_on_hand, image, trailer) values " +
                                        "(@movieTitle, @description, @movieYearMade, @genreId, @movieRating, @mediaType, @movieRetailCost, @copiesOnHand, @image, @trailer)";
            return DoNonQuery(movie, sqlStatement);
        }

        public bool UpdateMovie(Movie movie)
        {
            const string sqlStatement = "Update Movie set movie_title=@movieTitle, description=@description, movie_year_made=@movieYearMade, genre_id=@genreId, movie_rating=@movieRating, " +
                                        "media_type=@mediaType, movie_retail_cost=@movieRetailCost, copies_on_hand=@copiesOnHand, image=@image, trailer=@trailer " +
                                        "where id=@id";
            return DoNonQuery(movie, sqlStatement);
        }

        public bool DeleteMovie(int id)
        {
            var sqlStatement = "Delete from Movie where id=@id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                return NonQuery(com);
            }
        }

        private static Movie MapMovie(object[] item)
        {
            return new Movie
            {
                Id = int.Parse(item[0].ToString()),
                MovieTitle = item[1].ToString().TrimEnd(),
                Description = item[2].ToString().TrimEnd(),
                MovieYearMade = int.Parse(item[3].ToString()),
                GenreId = int.Parse(item[4].ToString()),
                MovieRating = item[5].ToString().TrimEnd(),
                MediaType = item[6].ToString().TrimEnd(),
                MovieRetailCost = decimal.Parse(item[7].ToString()),
                CopiesOnHand = int.Parse(item[8].ToString()),
                Image = item[9].ToString().TrimEnd(),
                Trailer = item[10].ToString().TrimEnd()
            };
        }

        private bool DoNonQuery(Movie movie, string sqlStatement)
        {
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", movie.Id);
                com.Parameters.AddWithValue("@movieTitle", movie.MovieTitle);
                com.Parameters.AddWithValue("@description", movie.Description);
                com.Parameters.AddWithValue("@movieYearMade", movie.MovieYearMade);
                com.Parameters.AddWithValue("@genreId", movie.GenreId);
                com.Parameters.AddWithValue("@movieRating", movie.MovieRating);
                com.Parameters.AddWithValue("@mediaType", movie.MediaType);
                com.Parameters.AddWithValue("@movieRetailCost", movie.MovieRetailCost);
                com.Parameters.AddWithValue("@copiesOnHand", movie.CopiesOnHand);
                com.Parameters.AddWithValue("@image", movie.Image);
                com.Parameters.AddWithValue("@trailer", movie.Trailer);
                return NonQuery(com);
            }
        }
    }
}
