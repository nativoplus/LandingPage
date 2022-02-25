namespace LandingPage.Domain.Entities
{
    public class Team
    {
        public string Name { get; set; } = "";
        public string Role { get; set; } = "";
        public string ImgUrl { get; set; } = "";
        public string Description { get; set; } = "";
        public string GithubUrl { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        public List<string> Projects { get; set; } = new List<string>();

    }
}
