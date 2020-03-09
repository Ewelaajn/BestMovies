namespace Best_Movies
{
    public class Movie
    {
        public Movie(string title, int userRating)
        {
            Title = title;
            UserRating = userRating;
        }

        public string Title { get; set; }
        public int UserRating { get; set; }

        public override string ToString()
        {
            return $"{Title}: {UserRating}";
        }
    }
}