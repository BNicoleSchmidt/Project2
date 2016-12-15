using System;

namespace MeramecNetFlixProject.BusinessObjects
{
    public class Rental
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int MemberId { get; set; }
        public DateTime MediaCheckoutDate { get; set; }
        public DateTime? MediaReturnDate { get; set; }
    }
}
