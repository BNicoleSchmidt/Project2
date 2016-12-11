namespace MeramecNetFlixProject.BusinessObjects
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public int MovieYearMade { get; set; }
        public int GenreId { get; set; }
        public string MovieRating { get; set; }
        public string MediaType { get; set; }
        public decimal MovieRetailCost { get; set; }
        public int CopiesOnHand { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
    }
}
