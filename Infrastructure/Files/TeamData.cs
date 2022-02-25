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
        public List<Team> Team { get; set; } = new List<Team> { 
            new Team
            {
                Name = "Hector Orellana Reyes",
                Role = "Software Engineer",
                Description = @"Hector has been a UI Developer with Nativo Plus Studio since January 2017.",
                ImgUrl = "template/images/team/hector.jpg",
                LinkedIn = "https://www.linkedin.com/in/hector-orellana-reyes-220b7a113/",
                GithubUrl = "https://github.com/horeyes",
                Projects = new List<string>{ "Gentlebirth" },
            },
            new Team
            {
                Name = "Jose Velez",
                Role = "Founder",
                Description = @"José founded Nativo Plus Studio and acquired BTMDT in 2021. Currently 
                based in the San Francico Bay Area, he has over 10 years of experience with ovreseing 
                the application development lifecycle from conception to implementation as a senior 
                software engineer and software architect in the public and private sectors.",
                ImgUrl = "template/images/team/jose.jpg",
                LinkedIn = "https://www.linkedin.com/in/joecolon/",
                GithubUrl = "https://github.com/jvelezc",
                Projects = new List<string>{ "TechCU", "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Angel Ramos",
                Role = "Software Engineer",
                Description = @"Angel has been a Software Engineer with Nativo Plus Studio since April 2017.  ",
                ImgUrl = "template/images/team/ramos.jpg",
                LinkedIn = "https://www.linkedin.com/in/angel-ramos-5a6a52a2/",
                GithubUrl = "https://github.com/joey0xx",
                Projects = new List<string>{ "TechCU"},
            },
            new Team
            {
                Name = "Arnaldo Rodriguez",
                Role = "Full Stack Developer",
                Description = @"Arnaldo has been a Full Stack Developer with Nativo Plus Studio since December 2016.  
                Based in Puerto Rico, Arnaldo has a broad range of experience with designing and developing web 
                applications using AngularJS, C#, and TypeScript.  ",
                ImgUrl = "template/images/team/arnaldo.jpg",
                LinkedIn = "https://www.linkedin.com/in/arnaldo-rodriguez-1445b811b/",
                GithubUrl = "https://github.com/arodriguezgb",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Cristian Amaro",
                Role = "Software Engineer",
                Description = @"Amaro brings a positive attiude to the office every day and brings experience in user 
                interface design by breaching the gap between users and the systems that power them.  ",
                ImgUrl = "template/images/team/amaro.jfif",
                LinkedIn = "https://www.linkedin.com/in/cristian-amaro-burgos-64815816a/",
                GithubUrl = "https://github.com/camaro24max",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Marie Fitch",
                Role = "COO",
                Description = @"Marie is a Creative specialist dedicated to finding original 
                design solutions to everyday life. Specialist in sales and marketing, facilitating 
                businesses to exceed sales objectives. ",
                ImgUrl = "template/images/team/marie.png",
                LinkedIn = "https://www.linkedin.com/in/mariefitch/",
                GithubUrl = "",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Angel Martinez",
                Role = "Full Stack Developer",
                Description = @"Angel has been a Full Stack Developer with Nativo Plus Studio since 
                August 2016.  Based in Puerto Rico, he has extensive expertise with developing web 
                applications using .NET, JavaScript, AngularJS, and TypeScript, and designing RESTful APIs.  ",
                ImgUrl = "template/images/team/martinez.jpg",
                LinkedIn = "https://www.linkedin.com/in/angel-isaac-martinez-437589a1/",
                GithubUrl = "",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Juliana Garrido",
                Role = "Art Director",
                Description = @"Juliana Garrido is an expert art and audiovisual director. Juliana’s focus on 
                storytelling, human-center design, design thinking and creativity have allowed her to build 
                and materialize unique concepts and ideas.",
                ImgUrl = "template/images/team/juliana.png",
                LinkedIn = "https://www.linkedin.com/in/juliana-galeano-garrido/",
                GithubUrl = "",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Danny Ruiz",
                Role = "UI Developer",
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris massa magna, 
                efficitur in condimentum a, pulvinar ut neque. Vestibulum pellentesque suscipit dapibus.",
                ImgUrl = "template/images/team/danny.jfif",
                LinkedIn = "https://www.linkedin.com/in/danny-stev-ruiz/",
                GithubUrl = "",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind" },
            }
        };
    }
}
