using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalConsoleApp.Genre
{
    internal class ActionMovie : Movie
    {
        public ActionMovie(string title, int releaseYear, string description) : base(title, releaseYear, description){}
    }
}
