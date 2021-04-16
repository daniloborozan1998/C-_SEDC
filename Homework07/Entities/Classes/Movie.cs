using System;
using System.Collections.Generic;
using System.Text;
using Entities.Enum;

namespace Entities.Classes
{
    public class Movie
    {
        public string Tittle { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string tittle, Genre genre, int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new Exception("Rating must be between 1 and 5");
            }

            if (string.IsNullOrEmpty(tittle))
            {
                throw new Exception("You must enter a tittle");
            }

            Tittle = tittle;
            Genre = genre;
            Rating = Rating;
            TicketPrice = 5 * rating;
        }
    }
}
