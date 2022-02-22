using LandingPage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Infrastructure.Files
{
    public class TeamData
    {
        public List<Team> Team { get; set; } = new List<Team> { new Team
        {
        Name = "Hector Orellana Reyes",
        Title = "Software Engineer",
        Description = "Lorem Ipsum",
        ImgUrl = "template/images/team/hector.jpg",
        LinkedIn = "https://www.linkedin.com/in/hector-orellana-reyes-220b7a113/",
        GithubUrl = "https://github.com/horeyes",
        Projects = new List<string>{ "Gentlebirth" },
        },
        new Team
        {
        Name = "Jose Velez",
        Title = "Founder",
        Description = "Lorem Ipsum",
        ImgUrl = "template/images/team/jose.jpg",
        LinkedIn = "https://www.linkedin.com/in/joecolon/",
        GithubUrl = "https://github.com/jvelezc",
        Projects = new List<string>{ "TechCU", "Gentlebirth", "Fertilemind" },
        },
        new Team
        {
        Name = "Angel Ramos",
        Title = "Software Engineer",
        Description = "Lorem Ipsum",
        ImgUrl = "template/images/team/ramos.jpg",
        LinkedIn = "https://www.linkedin.com/in/angel-ramos-5a6a52a2/",
        GithubUrl = "https://github.com/joey0xx",
        Projects = new List<string>{ "TechCU"},
        },
        new Team
        {
        Name = "Arnaldo Rodriguez",
        Title = "Software Engineer",
        Description = "Lorem Ipsum",
        ImgUrl = "template/images/team/arnaldo.jpg",
        LinkedIn = "https://www.linkedin.com/in/arnaldo-rodriguez-1445b811b/",
        GithubUrl = "",
        Projects = new List<string>{ "Gentlebirth", "Fertilemind" },

        },
        // new Team
        //{
        //    Name = "Angel Martinez",
        //    Title = "Software Engineer",
        //    Description = "Lorem Ipsum",
        //    ImgUrl = "template/images/team/martinez.jpg",
        //    LinkedIn = "",
        //    GithubUrl = "",
        //}};
        };
    }
}
