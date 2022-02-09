using Microsoft.AspNetCore.Components;

namespace LandingPage.Domain.Entities
{
    public class Article
    {
        public string Name { get; set; } = string.Empty;
        public string Headline { get; set; } = string.Empty;
        public MarkupString Body { get; set; } = new MarkupString(string.Empty);
        public List<string> ImgUrls { get; set; } = new List<string>();
        public List<string> Services { get; set; } = new List<string>();
        public List<string> Technologies { get; set; } = new List<string>();
        public List<string> Practices { get; set; } = new List<string>();
        public List<Team> Team { get; set; } = new List<Team>();
        public List<Reviews> Reviews { get; set; } = new List<Reviews>();
    }
}
