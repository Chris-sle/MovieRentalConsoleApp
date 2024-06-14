using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalConsoleApp.Genre
{
    internal class HorrorMovie : Movie
    {
        public HorrorMovie(string title, int releaseYear, string description) : base(title, releaseYear, description){}
    }
}
