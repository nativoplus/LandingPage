namespace LandingPage.Domain.Entities
{
    public class Article
    {
        public string Title { get; set; } = "";
        public List<string> Bullets { get; set; } = new List<string> { };
        public string PhotoUrl { get; set; } = "";
    }
}
