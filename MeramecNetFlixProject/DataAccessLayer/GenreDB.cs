using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.Exceptions;

namespace MeramecNetFlixProject.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class GenreDB : AccessDataSQLServer
    {
        public List<Genre> GetGenres()
        {
            const string sqlStatement = @"Select * from Genre";
            using (var com = new SqlCommand(sqlStatement))
            {
                var rawData = GetQuery(com);
                var genres = new List<Genre>();
                foreach (var item in rawData)
                {
                    var genre = MapGenre(item);
                    genres.Add(genre);
                }
                return genres;
            }
        }

        public Genre GetGenre(int id)
        {
            var sqlStatement = "Select * from Genre where id = @id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                var rawData = GetQuery(com);
                if (rawData.Count < 1)
                {
                    throw new NotFoundException("Genre not found");
                }
                var item = rawData.First();
                return MapGenre(item);
            }
        }

        public bool AddGenre(Genre genre)
        {
            const string sqlStatement = "Insert into Genre (name) values (@name)";
            return DoNonQuery(genre, sqlStatement);
        }

        public bool UpdateGenre(Genre genre)
        {
            const string sqlStatement = "Update Genre set name=@name where id=@id";
            return DoNonQuery(genre, sqlStatement);
        }

        public bool DeleteGenre(int id)
        {
            var sqlStatement = "Delete from Genre where id=@id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                return NonQuery(com);
            }
        }

        private static Genre MapGenre(object[] item)
        {
            return new Genre
            {
                Id = int.Parse(item[0].ToString()),
                Name = item[1].ToString().TrimEnd()
            };
        }

        private bool DoNonQuery(Genre genre, string sqlStatement)
        {
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", genre.Id);
                com.Parameters.AddWithValue("@name", genre.Name);
                return NonQuery(com);
            }
        }
    }
}
