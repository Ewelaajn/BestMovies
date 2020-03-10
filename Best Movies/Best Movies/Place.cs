namespace Best_Movies
{
    public class Place: Movie
    {
        public int PlaceNum { get; set; }
        public Place(string title, int userRating, int placeNum) : base(title, userRating)
        {
            PlaceNum = placeNum;
        }

        public override string ToString()
        {
            return $"{PlaceNum}. place: {Title} with {UserRating} points.";
        }
    }
}