using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.Exceptions;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class MovieDBFixture : BaseFixture
    {
        private MovieDB _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new MovieDB();
        }

        [Test]
        public void Get_Movies_Maps_From_DB_Data()
        {
            var actual = _testObject.GetMovies();
            var titles = actual.Select(x => x.MovieTitle).ToList();
            var descriptions = actual.Select(x => x.Description).ToList();

            Assert.That(actual.Count >= 2);

            Assert.That(titles.Contains("Rocky Horror Picture Show"));
            Assert.That(titles.Contains("Hitchhiker\'s Guide to the Galaxy"));
            Assert.That(descriptions.Contains("1975 horror comedy musical starring Tim Curry"));
        }

        [Test]
        public void Get_Movie_Returns_Correct_Movie()
        {
            var actual = _testObject.GetMovie(1);

            Assert.That(actual.MovieTitle, Is.EqualTo("Rocky Horror Picture Show"));
        }

        [Test]
        public void Get_Movie_Throws_If_Not_Found()
        {
            Assert.Throws<NotFoundException>(()=>_testObject.GetMovie(Random.Int32(100, 1000)));
        }

        [Test]
        public void Add_Movie_Adds_Movie()
        {
            var expected = RandomMovie();

            Assert.True(_testObject.AddMovie(expected));

            var actual = _testObject.GetMovies().First(m => m.MovieTitle == expected.MovieTitle);
            Assert.That(actual.Description, Is.EqualTo(expected.Description));
            Assert.That(actual.MovieYearMade, Is.EqualTo(expected.MovieYearMade));
            Assert.That(actual.GenreId, Is.EqualTo(expected.GenreId));
            Assert.That(actual.MovieRating, Is.EqualTo(expected.MovieRating));
            Assert.That(actual.MediaType, Is.EqualTo(expected.MediaType));
            Assert.That(actual.MovieRetailCost, Is.EqualTo(expected.MovieRetailCost));
            Assert.That(actual.CopiesOnHand, Is.EqualTo(expected.CopiesOnHand));
            Assert.That(actual.Image, Is.EqualTo(expected.Image));
            Assert.That(actual.Trailer, Is.EqualTo(expected.Trailer));
        }

        [Test]
        public void Add_Movie_Returns_False_On_Fail()
        {
            var badMovie = new Movie();

            Assert.False(_testObject.AddMovie(badMovie));
        }

        [Test]
        public void Update_Actually_Updates()
        {
            var old = RandomMovie();
            _testObject.AddMovie(old);
            var expected = RandomMovie();
            expected.Id = _testObject.GetMovies().First(m => m.MovieTitle == old.MovieTitle).Id;

            Assert.True(_testObject.UpdateMovie(expected));

            var actual = _testObject.GetMovie(expected.Id);
            Assert.That(actual.MovieTitle, Is.EqualTo(expected.MovieTitle));
            Assert.That(actual.Description, Is.EqualTo(expected.Description));
            Assert.That(actual.MovieYearMade, Is.EqualTo(expected.MovieYearMade));
            Assert.That(actual.GenreId, Is.EqualTo(expected.GenreId));
            Assert.That(actual.MovieRating, Is.EqualTo(expected.MovieRating));
            Assert.That(actual.MediaType, Is.EqualTo(expected.MediaType));
            Assert.That(actual.MovieRetailCost, Is.EqualTo(expected.MovieRetailCost));
            Assert.That(actual.CopiesOnHand, Is.EqualTo(expected.CopiesOnHand));
            Assert.That(actual.Image, Is.EqualTo(expected.Image));
            Assert.That(actual.Trailer, Is.EqualTo(expected.Trailer));
        }

        [Test]
        public void Delete_Actually_Deletes()
        {
            var movie = RandomMovie();
            _testObject.AddMovie(movie);
            var movieToDelete = _testObject.GetMovies().First(m => m.MovieTitle == movie.MovieTitle);

            Assert.True(_testObject.DeleteMovie(movieToDelete.Id));

            Assert.Throws<NotFoundException>(() => _testObject.GetMovie(movieToDelete.Id));
        }

        private Movie RandomMovie()
        {
            return new Movie
            {
                MovieTitle = Random.String(50),
                Description = Random.String(255),
                MovieYearMade = Random.Int32(),
                GenreId = Random.Int32(11),
                MovieRating = Random.String(5),
                MediaType = Random.String(10),
                MovieRetailCost = Random.Int32(),
                CopiesOnHand = Random.Int32(),
                Image = Random.String(30),
                Trailer = Random.String(30)
            };
        }
    }
}
