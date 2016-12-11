using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.Exceptions;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class GenreDBFixture : BaseFixture
    {
        private GenreDB _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new GenreDB();
        }

        [Test]
        public void Get_Genres_Maps_From_DB_Data()
        {
            var actual = _testObject.GetGenres();
            var names = actual.Select(x => x.Name).ToList();

            Assert.That(actual.Count >= 2);

            Assert.That(names.Contains("Drama"));
            Assert.That(names.Contains("Action"));
        }

        [Test]
        public void Get_Genre_Returns_Correct_Genre()
        {
            var actual = _testObject.GetGenre(1);

            Assert.That(actual.Name, Is.EqualTo("Childrens"));
        }

        [Test]
        public void Get_Genre_Throws_If_Not_Found()
        {
            Assert.Throws<NotFoundException>(()=>_testObject.GetGenre(Random.Int32(100, 1000)));
        }

        [Test]
        public void Add_Genre_Adds_Genre()
        {
            var expected = RandomGenre();

            Assert.True(_testObject.AddGenre(expected));

            Assert.IsNotNull(_testObject.GetGenres().First(m => m.Name == expected.Name));
        }

        [Test]
        public void Add_Genre_Returns_False_On_Fail()
        {
            var badGenre = new Genre();

            Assert.False(_testObject.AddGenre(badGenre));
        }

        [Test]
        public void Update_Actually_Updates()
        {
            var old = RandomGenre();
            _testObject.AddGenre(old);
            var expected = RandomGenre();
            expected.Id = _testObject.GetGenres().First(m => m.Name == old.Name).Id;

            Assert.True(_testObject.UpdateGenre(expected));

            var actual = _testObject.GetGenre(expected.Id);
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
        }

        [Test]
        public void Delete_Actually_Deletes()
        {
            var genre = RandomGenre();
            _testObject.AddGenre(genre);
            var genreToDelete = _testObject.GetGenres().First(m => m.Name == genre.Name);

            Assert.True(_testObject.DeleteGenre(genreToDelete.Id));

            Assert.Throws<NotFoundException>(() => _testObject.GetGenre(genreToDelete.Id));
        }

        private Genre RandomGenre()
        {
            return new Genre
            {
                Name = Random.String(30)
            };
        }
    }
}
