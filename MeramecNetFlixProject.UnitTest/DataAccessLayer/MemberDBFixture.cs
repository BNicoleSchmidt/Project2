using System.Linq;
using MeramecNetFlixProject.Business_Objects;
using MeramecNetFlixProject.Data_Access_Layer;
using MeramecNetFlixProject.Exceptions;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class MemberDBFixture : BaseFixture
    {
        private MemberDB _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new MemberDB();
        }

        [Test]
        public void Get_Members_Maps_From_DB_Data()
        {
            var actual = _testObject.GetMembers();
            var firstNames = actual.Select(x => x.FirstName).ToList();
            var lastNames = actual.Select(x => x.LastName).ToList();

            Assert.That(actual.Count >= 3);

            Assert.That(firstNames.Contains("Nicole"));
            Assert.That(firstNames.Contains("Tim"));
            Assert.That(firstNames.Contains("John"));
            Assert.That(lastNames.Contains("Schmidt"));
            Assert.That(lastNames.Contains("Stuart"));
            Assert.That(lastNames.Contains("Smith"));
        }

        [Test]
        public void Get_Member_Returns_Correct_Member()
        {
            var actual = _testObject.GetMember("nicole");

            Assert.That(actual.FirstName, Is.EqualTo("Nicole"));
        }

        [Test]
        public void Get_Member_Throws_If_Not_Found()
        {
            Assert.Throws<NotFoundException>(()=>_testObject.GetMember(Random.String()));
        }

        [Test]
        public void Add_Member_Adds_Member()
        {
            var expected = RandomMember();

            Assert.True(_testObject.AddMember(expected));

            var actual = _testObject.GetMember(expected.LoginName);
            Assert.That(actual.JoinDate, Is.EqualTo(expected.JoinDate));
            Assert.That(actual.FirstName, Is.EqualTo(expected.FirstName));
            Assert.That(actual.LastName, Is.EqualTo(expected.LastName));
            Assert.That(actual.Address, Is.EqualTo(expected.Address));
            Assert.That(actual.City, Is.EqualTo(expected.City));
            Assert.That(actual.State, Is.EqualTo(expected.State));
            Assert.That(actual.Zipcode, Is.EqualTo(expected.Zipcode));
            Assert.That(actual.Phone, Is.EqualTo(expected.Phone));
            Assert.That(actual.MemberStatus, Is.EqualTo(expected.MemberStatus));
            Assert.That(actual.LoginName, Is.EqualTo(expected.LoginName));
            Assert.That(actual.Password, Is.EqualTo(expected.Password));
            Assert.That(actual.Email, Is.EqualTo(expected.Email));
            Assert.That(actual.ContactMethod, Is.EqualTo(expected.ContactMethod));
            Assert.That(actual.SubscriptionId, Is.EqualTo(expected.SubscriptionId));
            Assert.That(actual.Photo, Is.EqualTo(expected.Photo));
            Assert.That(actual.IsAdmin, Is.EqualTo(expected.IsAdmin));
        }

        [Test]
        public void Add_Member_Returns_False_On_Fail()
        {
            var badMember = new Member();

            Assert.False(_testObject.AddMember(badMember));
        }

        [Test]
        public void Update_Actually_Updates()
        {
            var old = RandomMember();
            _testObject.AddMember(old);
            var storedOld = _testObject.GetMember(old.LoginName);
            var expected = RandomMember();
            expected.Id = storedOld.Id;

            Assert.True(_testObject.UpdateMember(expected));

            var actual = _testObject.GetMember(expected.LoginName);
            Assert.That(actual.Id, Is.EqualTo(storedOld.Id));
            Assert.That(actual.JoinDate, Is.EqualTo(expected.JoinDate));
            Assert.That(actual.FirstName, Is.EqualTo(expected.FirstName));
            Assert.That(actual.LastName, Is.EqualTo(expected.LastName));
            Assert.That(actual.Address, Is.EqualTo(expected.Address));
            Assert.That(actual.City, Is.EqualTo(expected.City));
            Assert.That(actual.State, Is.EqualTo(expected.State));
            Assert.That(actual.Zipcode, Is.EqualTo(expected.Zipcode));
            Assert.That(actual.Phone, Is.EqualTo(expected.Phone));
            Assert.That(actual.MemberStatus, Is.EqualTo(expected.MemberStatus));
            Assert.That(actual.LoginName, Is.EqualTo(expected.LoginName));
            Assert.That(actual.Password, Is.EqualTo(expected.Password));
            Assert.That(actual.Email, Is.EqualTo(expected.Email));
            Assert.That(actual.ContactMethod, Is.EqualTo(expected.ContactMethod));
            Assert.That(actual.SubscriptionId, Is.EqualTo(expected.SubscriptionId));
            Assert.That(actual.Photo, Is.EqualTo(expected.Photo));
            Assert.That(actual.IsAdmin, Is.EqualTo(expected.IsAdmin));
        }

        private Member RandomMember()
        {
            return new Member
            {
                JoinDate = Random.Date(),
                FirstName = Random.String(15),
                LastName = Random.String(25),
                Address = Random.String(30),
                City = Random.String(),
                State = Random.String(2),
                Zipcode = Random.Int32(99999),
                Phone = Random.String(10),
                MemberStatus = Random.String(1),
                LoginName = Random.String(),
                Password = Random.String(),
                Email = Random.String(),
                ContactMethod = Random.Int32(100) > 50 ? 1 : 2,
                SubscriptionId = Random.Int32(100) > 50 ? 1 : 2,
                Photo = Random.String(30),
                IsAdmin = Random.Int32(10) > 5
            };
        }
    }
}
