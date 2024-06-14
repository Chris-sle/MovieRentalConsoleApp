using System.ComponentModel;
using System.Xml.Linq;
using MovieRentalConsoleApp.Genre;

namespace MovieRentalConsoleApp
{
    internal class Store
    {
        public List<Movie> MoviesForRent { get; private set; }
        private List<Movie> _rentedMovies;

        public Store()
        {
            MoviesForRent = new List<Movie>();
            MoviesForRent.Add(new ActionMovie("En annen action film", 2000, "Her skjer det noe spennendes"));
            MoviesForRent.Add(new HorrorMovie("En annen horror film", 2000, "Her skjer det noe skummelt"));
            _rentedMovies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            MoviesForRent.Add(movie);
        }

        public void ShowMovies()
        {
            foreach (var movie in MoviesForRent)
            {
                movie.ShowMovieInfo();
                Console.WriteLine();
            }
        }

        public void ShowRentedMovies()
        {
            foreach (var movie in _rentedMovies)
            {
                movie.ShowMovieInfo();
                Console.WriteLine();
            }
        }

        public void RentMovie(Movie movie)
        {
            if (MoviesForRent.Remove(movie))
            {
                _rentedMovies.Add(movie);
                Console.WriteLine($"'{movie.Title}' has been moved from MoviesForRent to rentedMovies.");
            }
            else
            {
                Console.WriteLine($"'{movie.Title}' could not be found in MoviesForRent.");
            }
        }

        public void DeliverMovie(Movie movie)
        {
            if (_rentedMovies.Remove(movie))
            {
                MoviesForRent.Add(movie);
                Console.WriteLine($"'{movie.Title}' has been moved back to MoviesForRent.");
            }
            else
            {
                Console.WriteLine($"'{movie.Title}' could not be found in rentedMovies.");
            }
        }

        public void UserReview(Movie movie)
        {
            Console.WriteLine("Want to give a review of this movie?" +
                              "\n 1.Yes 2.No");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Enter rating 1-5");
                int rating = Convert.ToInt32(Console.ReadLine());
                if (rating > 6) movie.RateMovie(rating);
            }
            
        }
    }
}
