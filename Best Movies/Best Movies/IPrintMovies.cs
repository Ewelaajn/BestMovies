using System.Collections.Generic;

namespace Best_Movies
{
    public interface IPrintMovies
    {
        void PrintMovies(IEnumerable<Movie> movies);
    }
}