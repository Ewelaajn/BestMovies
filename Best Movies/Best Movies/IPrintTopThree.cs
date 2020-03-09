using System.Collections.Generic;

namespace Best_Movies
{
    public interface IPrintTopThree
    {
        void PrintMovies(IEnumerable<Movie> movies);
    }
}