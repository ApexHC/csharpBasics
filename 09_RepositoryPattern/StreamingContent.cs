namespace RepositoryPattern
{
    //POCO Plain Old CSharp Object
    public class StreamingContent
    {
        //Constructors
        public StreamingContent() {}
        public StreamingContent(string title, string description, double starRating, string maturityRating, bool isFamilyFriendly, int timeInMinutes)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = maturityRating;
            IsFamilyFriendly = isFamilyFriendly;
            RuntimeInMinutes = timeInMinutes;
        }
    
        //Property
        //AccessModifier Type Name Getter Setter
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public string MaturityRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public int RuntimeInMinutes { get; set; }

        //Methods
    }
}