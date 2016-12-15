using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.Exceptions;

namespace MeramecNetFlixProject.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class RentalDB : AccessDataSQLServer
    {
        public List<Rental> GetRentals()
        {
            const string sqlStatement = @"Select * from Rental";
            using (var com = new SqlCommand(sqlStatement))
            {
                var rawData = GetQuery(com);
                var rentals = new List<Rental>();
                foreach (var item in rawData)
                {
                    var rental = MapRental(item);
                    rentals.Add(rental);
                }
                return rentals;
            }
        }

        public Rental GetRental(int id)
        {
            var sqlStatement = "Select * from Rental where id = @id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                var rawData = GetQuery(com);
                if (rawData.Count < 1)
                {
                    throw new NotFoundException("Rental not found");
                }
                var item = rawData.First();
                return MapRental(item);
            }
        }

        public bool AddRental(Rental rental)
        {
            const string sqlStatement = "Insert into Rental (movie_id, member_id, media_checkout_date, media_return_date) values " +
                                        "(@movieId, @memberId, @mediaCheckoutDate, @mediaReturnDate)";
            return DoNonQuery(rental, sqlStatement);
        }

        public bool UpdateRental(Rental rental)
        {
            const string sqlStatement = "Update Rental set movie_id=@movieId, member_id=@memberId, media_checkout_date=@mediaCheckoutDate, " +
                                        "media_return_date=@mediaReturnDate where id=@id";
            return DoNonQuery(rental, sqlStatement);
        }

        public bool DeleteRental(int id)
        {
            var sqlStatement = "Delete from Rental where id=@id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                return NonQuery(com);
            }
        }

        private static Rental MapRental(object[] item)
        {
            var rental = new Rental
            {
                Id = int.Parse(item[0].ToString()),
                MovieId = int.Parse(item[1].ToString()),
                MemberId = int.Parse(item[2].ToString()),
                MediaCheckoutDate = (DateTime)item[3]
            };
            DateTime d;
            if (DateTime.TryParse(item[4].ToString(), out d))
            {
                rental.MediaReturnDate = d;
            }
            return rental;
        }

        private bool DoNonQuery(Rental rental, string sqlStatement)
        {
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", rental.Id);
                com.Parameters.AddWithValue("@movieId", rental.MovieId);
                com.Parameters.AddWithValue("@memberId", rental.MemberId);
                com.Parameters.AddWithValue("@mediaCheckoutDate", rental.MediaCheckoutDate);
                com.Parameters.AddWithValue("@mediaReturnDate", rental.MediaReturnDate);
                return NonQuery(com);
            }
        }
    }
}
