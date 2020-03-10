using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Best_Movies
{
    public class Top_3: IPrintMovies
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
            var topThreeMovies = new List<Movie>();

            foreach (var movie in _movies)
            {
                if (stack.Count == 0)
                {
                    stack.Push(new Place(movie.Title, movie.UserRating, i));
                }
                else if (stack.Peek().UserRating == movie.UserRating)
                { 
                    stack.Push(new Place(movie.Title, movie.UserRating, i));
                }
                else if (i == 3)
                {
                    break;
                }
                else
                {
                    i++;
                    stack.Push(new Place(movie.Title, movie.UserRating, i));
                }
            }

            var result = stack.ToList();
            result.Reverse();
            
            return result;
        }

        public void PrintMovies(IEnumerable<Movie> movies)
        {
            foreach(var movie in movies)
            Console.WriteLine(movie);
        }
    }
    
}