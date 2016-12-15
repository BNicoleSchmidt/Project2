using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.Exceptions;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class RentalDBFixture : BaseFixture
    {
        private RentalDB _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new RentalDB();
        }

        [Test]
        public void Get_Rentals_Maps_From_DB_Data()
        {
            var actual = _testObject.GetRentals();
            var rental1 = actual.First(x => x.Id == 1);
            var rental2 = actual.First(x => x.Id == 2);

            Assert.That(actual.Count >= 2);

            Assert.That(rental1.MemberId == 1);
            Assert.That(rental1.MovieId == 1);
            Assert.That(rental1.MediaCheckoutDate.ToString(), Is.EqualTo("11/11/2016 12:00:00 AM"));
            Assert.That(rental1.MediaReturnDate.ToString(), Is.EqualTo("11/12/2016 12:00:00 AM"));
            Assert.That(rental2.MemberId == 2);
            Assert.That(rental2.MovieId == 2);
            Assert.That(rental2.MediaCheckoutDate.ToString(), Is.EqualTo("11/12/2016 12:00:00 AM"));
            Assert.IsNull(rental2.MediaReturnDate);
        }

        [Test]
        public void Get_Rental_Returns_Correct_Rental()
        {
            var actual = _testObject.GetRental(1);

            Assert.That(actual.MemberId, Is.EqualTo(1));
        }

        [Test]
        public void Get_Rental_Throws_If_Not_Found()
        {
            Assert.Throws<NotFoundException>(()=>_testObject.GetRental(Random.Int32(100, 1000)));
        }

        [Test]
        public void Add_Rental_Adds_Rental()
        {
            var expected = RandomRental();

            Assert.True(_testObject.AddRental(expected));

            var actual = _testObject.GetRentals().First(m => m.MemberId == expected.MemberId && m.MovieId == expected.MovieId);
            Assert.That(actual.MediaCheckoutDate, Is.EqualTo(expected.MediaCheckoutDate));
            Assert.That(actual.MediaReturnDate, Is.EqualTo(expected.MediaReturnDate));

        }

        [Test]
        public void Add_Rental_Returns_False_On_Fail()
        {
            var badRental = new Rental();

            Assert.False(_testObject.AddRental(badRental));
        }

        [Test]
        public void Update_Actually_Updates()
        {
            var old = RandomRental();
            _testObject.AddRental(old);
            var expected = RandomRental();
            expected.Id = _testObject.GetRentals().First(m => m.MemberId == old.MemberId && m.MovieId == old.MovieId).Id;

            Assert.True(_testObject.UpdateRental(expected));

            var actual = _testObject.GetRental(expected.Id);
            Assert.That(actual.MemberId, Is.EqualTo(expected.MemberId));
            Assert.That(actual.MovieId, Is.EqualTo(expected.MovieId));
            Assert.That(actual.MediaCheckoutDate, Is.EqualTo(expected.MediaCheckoutDate));
            Assert.That(actual.MediaReturnDate, Is.EqualTo(expected.MediaReturnDate));
        }

        [Test]
        public void Delete_Actually_Deletes()
        {
            var rental = RandomRental();
            _testObject.AddRental(rental);
            var rentalToDelete = _testObject.GetRentals().First(m => m.MovieId == rental.MovieId && m.MemberId == rental.MemberId);

            Assert.True(_testObject.DeleteRental(rentalToDelete.Id));

            Assert.Throws<NotFoundException>(() => _testObject.GetRental(rentalToDelete.Id));
        }

        private Rental RandomRental()
        {
            return new Rental
            {
                MovieId = Random.Int32(6),
                MemberId = Random.Int32(4),
                MediaCheckoutDate = Random.Date(),
                MediaReturnDate = Random.Date()
            };
        }
    }
}
