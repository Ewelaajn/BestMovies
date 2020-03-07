using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;


namespace Best_Movies
{
    class Program
    {
        static void Main()
        {
            var listOfMovies = new List<Movie>()
            {
                new Movie("Saw", 7),
                new Movie("Parasite", 9),
                new Movie("Kler", 7),
                new Movie("Joker", 8),
                new Movie("Green Book", 9),
                new Movie("1917", 6),
                new Movie("Boże Ciało", 3),
                new Movie("Dunkirk", 5),
                new Movie("The invisivle man", 7),
                new Movie("The Lego movie", 10),
                new Movie("Lego Batman", 10),
                new Movie("Ford vs Ferrari", 8)
            };
        }
    }
}