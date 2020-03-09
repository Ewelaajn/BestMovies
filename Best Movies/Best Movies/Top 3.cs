using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Best_Movies
{
    public class Top_3: IPrintTopThree
    {
        private readonly IEnumerable<Movie> _movies;

        public Top_3(IEnumerable<Movie> sortedMovies)
        {
            _movies = sortedMovies;
        }

        public IEnumerable<Movie> TopThree()
        {
            var stack = new Stack<Movie>();
            int i = 1;

            foreach (var movie in _movies)
            {
                if (stack.Count == 0)
                {
                    stack.Push(movie);
                }
                else if (stack.Peek().UserRating == movie.UserRating)
                { 
                    stack.Push(movie);
                }
                else if (i == 3)
                {
                    break;
                }
                else
                {
                    stack.Push(movie);
                    i++;
                }
            }

            var result = stack.ToList();
            result.Reverse();
            
            return result;
        }

        public void PrintMovies(IEnumerable<Movie> movies)
        {
          
            
        }
    }
    
}