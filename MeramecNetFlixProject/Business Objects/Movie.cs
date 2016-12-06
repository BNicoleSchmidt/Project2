using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.Business_Objects
{
    class Movie
    {
        public int MovieNumber { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public DateTime MovieYearMade { get; set; }
        public int GenreID { get; set; }
        public string MovieRating { get; set; }
        public string MediaType { get; set; }
        public int MovieRentalCost { get; set; }
        public int CopiesOnHand { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
    }
}
