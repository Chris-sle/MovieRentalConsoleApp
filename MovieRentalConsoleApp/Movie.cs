using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalConsoleApp
{
    public abstract class Movie
    {
        public string Title { get; private set; }
        public int ReleaseYear { get; private set; }
        public string Description { get; private set; }
        private int _movieRating;
        private int _numberOfRatings;
        public bool InStock { get; private set; }

        protected Movie(string title, int releaseYear, string description)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Description = description;
            _movieRating = 0;
            _numberOfRatings = 0;
            InStock = true;
        }

        public void ShowMovieInfo()
        {
            Console.WriteLine("Title: " + Title +
                              "\nReleased: " + ReleaseYear +
                              "\nSynopsis: " + Description +
                              "\n"+ _numberOfRatings + " " + "users has rated this movie: " + _movieRating + " stars");
        }


        public void RateMovie(int rating)
        {
            _numberOfRatings++;
            _movieRating += rating / _numberOfRatings;
        }
    }
}
