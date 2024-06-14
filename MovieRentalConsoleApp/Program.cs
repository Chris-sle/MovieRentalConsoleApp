using System.Reflection;
using MovieRentalConsoleApp.Genre;

namespace MovieRentalConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            var movie1 = new ActionMovie("En Action Film", 2024, "En film om meg");
            var movie2 = new HorrorMovie("En Skrekk Film", 2024, "En film om deg");
            
            store.AddMovie(movie1);
            store.AddMovie(movie2);

            Console.WriteLine("Available Movies:");
            store.ShowMovies();

            store.RentMovie(movie1);

            Console.WriteLine("\nAvailable Movies after renting one movie:");
            store.ShowMovies();

            store.ShowRentedMovies();

            store.UserReview(movie2);

            store.DeliverMovie(movie1);
            Console.WriteLine("\nAvailable Movies after returning one movie:");
            store.ShowMovies();

            Console.WriteLine("\nRented Movies:");
            store.ShowRentedMovies();

            Console.ReadLine();
        }
    }
}
