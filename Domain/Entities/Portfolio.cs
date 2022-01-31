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
        public List<Services> Services { get; set; } = new List<Services>();
        public List<Technologies> Technologies { get; set; } = new List<Technologies>();
        public List<Practices> Practices { get; set; } = new List<Practices>();

    }
}
