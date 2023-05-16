using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRatings
{
    public class Movie
    {
        // public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        public double Rating { get; set; }
        public Movie(string title, string director, int year,double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
        }
        public Movie()
        { }
    }
}