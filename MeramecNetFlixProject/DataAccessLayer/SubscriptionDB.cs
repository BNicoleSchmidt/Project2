using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.Exceptions;

namespace MeramecNetFlixProject.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class SubscriptionDB : AccessDataSQLServer
    {
        public List<Subscription> GetSubscriptions()
        {
            const string sqlStatement = @"Select * from Subscription";
            using (var com = new SqlCommand(sqlStatement))
            {
                var rawData = GetQuery(com);
                var subscriptions = new List<Subscription>();
                foreach (var item in rawData)
                {
                    var subscription = MapSubscription(item);
                    subscriptions.Add(subscription);
                }
                return subscriptions;
            }
        }

        public Subscription GetSubscription(int id)
        {
            var sqlStatement = "Select * from Subscription where id = @id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                var rawData = GetQuery(com);
                if (rawData.Count < 1)
                {
                    throw new NotFoundException("Subscription not found");
                }
                var item = rawData.First();
                return MapSubscription(item);
            }
        }

        public bool AddSubscription(Subscription subscription)
        {
            const string sqlStatement = "Insert into Subscription (name, cost) values (@name, @cost)";
            return DoNonQuery(subscription, sqlStatement);
        }

        public bool UpdateSubscription(Subscription subscription)
        {
            const string sqlStatement = "Update Subscription set name=@name, cost=@cost where id=@id";
            return DoNonQuery(subscription, sqlStatement);
        }

        public bool DeleteSubscription(int id)
        {
            var sqlStatement = "Delete from Subscription where id=@id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                return NonQuery(com);
            }
        }

        private static Subscription MapSubscription(object[] item)
        {
            return new Subscription
            {
                Id = int.Parse(item[0].ToString()),
                Name = item[1].ToString().TrimEnd(),
                Cost = decimal.Parse(item[2].ToString())
            };
        }

        private bool DoNonQuery(Subscription subscription, string sqlStatement)
        {
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", subscription.Id);
                com.Parameters.AddWithValue("@name", subscription.Name);
                com.Parameters.AddWithValue("@cost", subscription.Cost);
                return NonQuery(com);
            }
        }
    }
}
