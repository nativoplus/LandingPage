using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Domain.Entities
{
    public class Portfolio
    {
        public int ProjectId { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Headline { get; set; } = string.Empty;
        public MarkupString Body { get; set; } = new MarkupString(string.Empty);
        public string ImgUrl { get; set; } = string.Empty;
        public List<string> Services { get; set; } = new List<string>();
        public List<string> Technologies { get; set; } = new List<string>();
        public List<string> Practices { get; set; } = new List<string>();
        public List<Team> Team { get; set; } = new List<Team>();

    }
}
