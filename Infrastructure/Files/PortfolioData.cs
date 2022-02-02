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
                ImgUrls = new List<string>{
                    "template/images/assets/gb/gentlebirth.png",
                    "template/images/assets/gb/backoffice.png",
                    //"template/images/assets/gb/templates.jpg",
                },
                Services = new List<string>
                {
                    "Web development",
                    "Web Design",
                    "Social Media Managment",
                    "Mobile App Redesign",
                    "API Development",
                    "Database Design",
                    "Server Management",
                    "Deployment Automation"
                },
                Technologies = new List<string>
                {
                    "Flutter / Dart",
                    "HTML / CSS",
                    "Angular",
                    ".Net Core",
                    "Microsoft Azure",
                    "Firebase",
                    "SQL Server"

                },
                Practices = new List<string>
                {
                    "User Research",
                    "UX Design",
                    "Agile Development",
                    "Restful API",
                    "Data Management",
                    "Technical Discovery",
                    "Mobile Design",
                    "Product Management",
                    "Cloud Hosting",
                    "Open Source Development"
                },
                Team = new List<Team>
                {
                    new Team
                    {
                        Name = "Hector Orellana Reyes",
                        Title = "Software Engineer",
                        Description = "Lorem Ipsum",
                        ImgUrl = "template/images/team/hector.jpg",
                        LinkedIn = "",
                        GithubUrl = "",
                    },
                    new Team
                    {
                        Name = "Arnaldo Rodriguez",
                        Title = "Software Engineer",
                        Description = "Lorem Ipsum",
                        ImgUrl = "template/images/team/arnaldo.jpg",
                        LinkedIn = "",
                        GithubUrl = "",
                    },
                }
            },
            new Portfolio
            {
                ProjectId = 1,
                Name = "Fertilemind",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Fertilemind is an app that approaches infertility by intentional
                mental activity improving reproductive health cycles. It combines
                guidance from the Award Winning FertileMind Program with an
                interface to make your fertility journey effective and stress-free.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Fertilemind needed an App focused on UX and a clean and easyto-
                use platform. We develop a user interface to showcase its
                apps and provide a tool for its users to interact with the app. We
                decided to build a UI based on the React framework, which was
                already being used in the backend.</p>"),
                ImgUrls = new List<string>{
                    "template/images/assets/fm/fertilemind.png",
                    //"template/images/assets/gb/templates.jpg",
                },
                Services = new List<string>
                {
                    "Web development",
                    "Web Design",
                    "Social Media Managment",
                    "Mobile App Redesign",
                    "API Development",
                    "Database Design",
                    "Server Management",
                    "Deployment Automation"
                },
                Technologies = new List<string>
                {
                    "Flutter / Dart",
                    "Firebase",
                    "SQL Server"

                },
                Practices = new List<string>
                {
                    "User Research",
                    "UX Design",
                    "Agile Development",
                    "Restful API",
                    "Data Management",
                    "Technical Discovery",
                    "Mobile Design",
                    "Product Management",
                    "Cloud Hosting",
                    "Open Source Development"
                },
                Team = new List<Team>
                {
                    new Team
                    {
                        Name = "Arnaldo Rodriguez",
                        Title = "Software Engineer",
                        Description = "Lorem Ipsum",
                        ImgUrl = "template/images/team/arnaldo.jpg",
                        LinkedIn = "",
                        GithubUrl = "",
                    },
                }
            },
            new Portfolio
            {
                ProjectId = 3,
                Name = "Techcu",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Techcu is a credit union that was founded in Silicon Valley, dedicated to the financial success of its members.
                Instead of maximizing profits to pay company stockholders, Techcu invests resources to deliver superior rates, lower fees,
                and outstanding service and member benefits.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Techcu was interested in creating a member-centered website that provided members with the
                information they needed and represented their values as well. We have provided Techcu with a number of services, one of these
                is Restful Apis, which can process thousands of loans daily in a consortium-like environment from multiple partners. We created
                Fintech-focused APIs so that multiple partners can process loans, access member information, create transfers, and manage external
                loans using Azure logic apps and azure functions.</p>
                <div class='row'>
                    <div class='col-md-6'>
                        <p>
                            Additionally, we have delivered extensive support
                            for their legacy apps, improving code quality, creating development, staging and production environments as well. Our long-standing
                            mission has been to position Techcu in the fintech industry, by providing enterprise services, APis, infrastructure that enhance
                            their offerings to the fintech world, granting them multiple partnerships across automobile and solar industries with many more to
                            come.
                        </p> 
                    </div>
                    <div class='col-md-6'>
                        <div class='dots-image-2'>
                            <img alt='' class='img-responsive' src='template/images/assets/fm/fertilemind.png'>
                            <div class='dots'></div>
                        </div>
                    </div>
                    <div class='col-md-6'>
                        <div class='dots-image-2'>
                            <img alt='' class='img-responsive' src='template/images/assets/fm/fertilemind.png'>
                            <div class='dots'></div>
                        </div>
                    </div>
                     <div class='col-md-6'>
                        <p>
                            Additionally, we have delivered extensive support
                            for their legacy apps, improving code quality, creating development, staging and production environments as well. Our long-standing
                            mission has been to position Techcu in the fintech industry, by providing enterprise services, APis, infrastructure that enhance
                            their offerings to the fintech world, granting them multiple partnerships across automobile and solar industries with many more to
                            come.
                        </p> 
                    </div>
                </div>"),
                ImgUrls = new List<string>{
                    "template/images/assets/fm/fertilemind.png",
                    //"template/images/assets/gb/templates.jpg",
                },
                Services = new List<string>
                {
                    "Web development",
                    "Web Design",
                    "Social Media Managment",
                    "Mobile App Redesign",
                    "API Development",
                    "Database Design",
                    "Server Management",
                    "Deployment Automation"
                },
                Technologies = new List<string>
                {
                    "Flutter / Dart",
                    "Firebase",
                    "SQL Server"

                },
                Practices = new List<string>
                {
                    "User Research",
                    "UX Design",
                    "Agile Development",
                    "Restful API",
                    "Data Management",
                    "Technical Discovery",
                    "Mobile Design",
                    "Product Management",
                    "Cloud Hosting",
                    "Open Source Development"
                },
                Team = new List<Team>
                {
                    new Team
                    {
                        Name = "Arnaldo Rodriguez",
                        Title = "Software Engineer",
                        Description = "Lorem Ipsum",
                        ImgUrl = "template/images/team/arnaldo.jpg",
                        LinkedIn = "",
                        GithubUrl = "",
                    },
                }
            }
        };
    }
}
