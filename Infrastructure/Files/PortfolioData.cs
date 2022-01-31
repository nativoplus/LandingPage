using LandingPage.Domain.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Infrastructure.Files
{
    public class PortfolioData
    {
        public List<Portfolio> portfolio = new List<Portfolio>
        {
            new Portfolio
            {
                ProjectId = 0,
                Name = "Gentlebirth",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"GentleBirth is an App that takes pregnant women from fear to confidence
                in their childbirth preparation. Mindfulness, breathing techniques, affirmations, and hypnosis are
                combined with evidence-based research and technology to provide a holistic birthing experience.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Gentlebirth was looking for improved the design, modified the structure, 
                and refactored the implementation of multiple React components within a responsive web app, accessed by thousands 
                of users, based on business requirements, user requests, and customer feedback. Additionally, they were looking 
                to streamline the process of managing sessions, journeys, playlists, and promotions.</p>"),
                ImgUrl = "template/images/assets/gentlebirth.png",
                Services = new List<Services>
                {
                    new Services
                    {
                        Service = "Web development",
                    },
                    new Services
                    {
                        Service = "Web Design",
                    },
                    new Services
                    {
                        Service = "Social Media Managment",
                    },
                    new Services
                    {
                        Service = "Mobile App Redesign",
                    },
                    new Services
                    {
                        Service = "API Development",
                    },
                    new Services
                    {
                        Service = "Database Design",
                    },
                    new Services
                    {
                        Service = "Server Management",
                    },
                    new Services
                    {
                        Service = "Deployment Automation",
                    },
                },
                Technologies = new List<Technologies>
                {
                    new Technologies
                    {
                        Technology = "Flutter / Dart"
                    },
                    new Technologies
                    {
                        Technology = "HTML / CSS"
                    },
                    new Technologies
                    {
                        Technology = "Angular"
                    },
                    new Technologies
                    {
                        Technology = ".Net Core"
                    },
                    new Technologies
                    {
                        Technology = "Microsoft Azure"
                    },
                    new Technologies
                    {
                        Technology = "Firebase"
                    },
                    new Technologies
                    {
                        Technology = "SQL Server"
                    },

                }
            }
        };
    }
}
