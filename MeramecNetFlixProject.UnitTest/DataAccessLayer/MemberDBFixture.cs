using System.Linq;
using MeramecNetFlixProject.Data_Access_Layer;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class MemberDBFixture : BaseFixture
    {
        MemberDB _testObject;

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
    }
}
