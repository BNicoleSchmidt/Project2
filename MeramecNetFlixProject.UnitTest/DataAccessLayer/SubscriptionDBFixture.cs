using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.Exceptions;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class SubscriptionDBFixture : BaseFixture
    {
        private SubscriptionDB _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new SubscriptionDB();
        }

        [Test]
        public void Get_Subscriptions_Maps_From_DB_Data()
        {
            var actual = _testObject.GetSubscriptions();
            var names = actual.Select(x => x.Name).ToList();
            var costs = actual.Select(x => x.Cost).ToList();

            Assert.That(actual.Count >= 2);

            Assert.That(names.Contains("Standard"));
            Assert.That(names.Contains("Plus"));
            Assert.That(costs.Contains(10));
            Assert.That(costs.Contains(15));
        }

        [Test]
        public void Get_Subscription_Returns_Correct_Subscription()
        {
            var actual = _testObject.GetSubscription(1);

            Assert.That(actual.Name, Is.EqualTo("Standard"));
        }

        [Test]
        public void Get_Subscription_Throws_If_Not_Found()
        {
            Assert.Throws<NotFoundException>(()=>_testObject.GetSubscription(Random.Int32(100, 1000)));
        }

        [Test]
        public void Add_Subscription_Adds_Subscription()
        {
            var expected = RandomSubscription();

            Assert.True(_testObject.AddSubscription(expected));

            var actual = _testObject.GetSubscriptions().First(m => m.Name == expected.Name);
            Assert.That(actual.Cost, Is.EqualTo(expected.Cost));
        }

        [Test]
        public void Add_Subscription_Returns_False_On_Fail()
        {
            var badSubscription = new Subscription();

            Assert.False(_testObject.AddSubscription(badSubscription));
        }

        [Test]
        public void Update_Actually_Updates()
        {
            var old = RandomSubscription();
            _testObject.AddSubscription(old);
            var expected = RandomSubscription();
            expected.Id = _testObject.GetSubscriptions().First(m => m.Name == old.Name).Id;

            Assert.True(_testObject.UpdateSubscription(expected));

            var actual = _testObject.GetSubscription(expected.Id);
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
            Assert.That(actual.Cost, Is.EqualTo(expected.Cost));
        }

        [Test]
        public void Delete_Actually_Deletes()
        {
            var subscription = RandomSubscription();
            _testObject.AddSubscription(subscription);
            var subscriptionToDelete = _testObject.GetSubscriptions().First(m => m.Name == subscription.Name);

            Assert.True(_testObject.DeleteSubscription(subscriptionToDelete.Id));

            Assert.Throws<NotFoundException>(() => _testObject.GetSubscription(subscriptionToDelete.Id));
        }

        private Subscription RandomSubscription()
        {
            return new Subscription
            {
                Name = Random.String(),
                Cost = Random.Int32()
            };
        }
    }
}
