using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.Exceptions;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class ContactMethodDBFixture : BaseFixture
    {
        private ContactMethodDB _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new ContactMethodDB();
        }

        [Test]
        public void Get_ContactMethods_Maps_From_DB_Data()
        {
            var actual = _testObject.GetContactMethods();
            var names = actual.Select(x => x.Name).ToList();

            Assert.That(actual.Count >= 2);

            Assert.That(names.Contains("Email"));
            Assert.That(names.Contains("Phone"));
        }

        [Test]
        public void Get_ContactMethod_Returns_Correct_ContactMethod()
        {
            var actual = _testObject.GetContactMethod(1);

            Assert.That(actual.Name, Is.EqualTo("Phone"));
        }

        [Test]
        public void Get_ContactMethod_Throws_If_Not_Found()
        {
            Assert.Throws<NotFoundException>(()=>_testObject.GetContactMethod(Random.Int32(100, 1000)));
        }

        [Test]
        public void Add_ContactMethod_Adds_ContactMethod()
        {
            var expected = RandomContactMethod();

            Assert.True(_testObject.AddContactMethod(expected));

            Assert.IsNotNull(_testObject.GetContactMethods().First(m => m.Name == expected.Name));
        }

        [Test]
        public void Add_ContactMethod_Returns_False_On_Fail()
        {
            var badContactMethod = new ContactMethod();

            Assert.False(_testObject.AddContactMethod(badContactMethod));
        }

        [Test]
        public void Update_Actually_Updates()
        {
            var old = RandomContactMethod();
            _testObject.AddContactMethod(old);
            var expected = RandomContactMethod();
            expected.Id = _testObject.GetContactMethods().First(m => m.Name == old.Name).Id;

            Assert.True(_testObject.UpdateContactMethod(expected));

            var actual = _testObject.GetContactMethod(expected.Id);
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
        }

        [Test]
        public void Delete_Actually_Deletes()
        {
            var contactMethod = RandomContactMethod();
            _testObject.AddContactMethod(contactMethod);
            var contactMethodToDelete = _testObject.GetContactMethods().First(m => m.Name == contactMethod.Name);

            Assert.True(_testObject.DeleteContactMethod(contactMethodToDelete.Id));

            Assert.Throws<NotFoundException>(() => _testObject.GetContactMethod(contactMethodToDelete.Id));
        }

        private ContactMethod RandomContactMethod()
        {
            return new ContactMethod
            {
                Name = Random.String(30)
            };
        }
    }
}
