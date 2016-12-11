using System;

namespace MeramecNetFlixProject.BusinessObjects
{
    public class Rental
    {
        public int Id { get; set; }
        public int MovieNumber { get; set; }
        public int MemberNumber { get; set; }
        public DateTime MediaCheckoutDate { get; set; }
        public DateTime? MediaReturnDate { get; set; }
    }
}
