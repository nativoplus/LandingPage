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
                Description = @"Hector is a software developer with a wealth of knowledge and experience. He is fearless and 
                is up for any challenge. With his immense creativity and innovative nature, he can create the software your 
                organization needs to stay in front of your competition. Hector loves to deliver practical, reliable services 
                that go above the needs of any project. He loves to see clients become better versions of themselves through 
                his expert endeavors. ",
                ImgUrl = "template/images/team/hector-small.webp",
                LinkedIn = "https://www.linkedin.com/in/hector-orellana-reyes-220b7a113/",
                GithubUrl = "https://github.com/horeyes",
                Projects = new List<string>{ "Gentlebirth", "Advantage For Analysts"},
            },
            new Team
            {
                Name = "Jose Velez",
                Role = "Founder",
                Description = @"José founded Nativo Plus Studio and acquired BTMDT in 2021. He resides in the San Francisco Bay Area. 
                He has over ten years of experience overseeing the application development lifecycle from conception to implementation 
                as a senior software engineer and software architect in the public and private sectors. ",
                ImgUrl = "template/images/team/jose-small.webp",
                LinkedIn = "https://www.linkedin.com/in/joecolon/",
                GithubUrl = "https://github.com/jvelezc",
                Projects = new List<string>{ "TechCU", "Gentlebirth", "Fertilemind", "Advantage For Analysts", "Westcor", "Stripe", "Maxana"},
            },
            new Team
            {
                Name = "Angel Ramos",
                Role = "Software Engineer",
                Description = @"Angel Ramos enjoys learning and staying on top of the latest trends for writing code. He 
                specializes in NativeScript and APIs for mobile healthcare applications. Angel dedicates to ensuring quality 
                and delivering value on every project.",
                ImgUrl = "template/images/team/ramos-small.webp",
                LinkedIn = "https://www.linkedin.com/in/angel-ramos-5a6a52a2/",
                GithubUrl = "https://github.com/joey0xx",
                Projects = new List<string>{},
            },
            new Team
            {
                Name = "Arnaldo Rodriguez",
                Role = "Software Engineer",
                Description = @"Arnaldo is focused and passionate about creating quality products by ensuring they have a great
                design and the code that executes well. He likes to follow the best practices and latest design patterns. He 
                showcases professionality that cultivates a healthy work environment while empowering creativity. ",
                ImgUrl = "template/images/team/arnaldo-small.webp",
                LinkedIn = "https://www.linkedin.com/in/arnaldo-rodriguez-1445b811b/",
                GithubUrl = "https://github.com/arodriguezgb",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind", "Advantage For Analysts" },
            },
            new Team
            {
                Name = "Cristian Amaro",
                Role = "Software Engineer",
                Description = @"Cristian knows that websites are about people and is ready to make sure those people shine as 
                bright as the sun. He is dedicated to full-stack web development and focuses on designing modern web-based 
                solutions for his clients. Cristian experienced on development life-cycle of team-based web projects.",
                ImgUrl = "template/images/team/amaro-small.webp",
                LinkedIn = "https://www.linkedin.com/in/cristian-amaro-burgos-64815816a/",
                GithubUrl = "https://github.com/camaro24max",
                Projects = new List<string>{ "Happy Volts"},
            },
            new Team
            {
                Name = "Marie Fitch",
                Role = "COO",
                Description = @" Marie is a Creative Specialist dedicated to finding original design solutions to 
                everyday life. Specializing in sales and marketing, she always facilitates businesses to exceed 
                sales objectives. Making her clients the cream of the crop is her highest priority. ",
                ImgUrl = "template/images/team/marie-small.webp",
                LinkedIn = "https://www.linkedin.com/in/mariefitch/",
                GithubUrl = "",
                Projects = new List<string>{ "Kati Sportcap & Bag", "Farm to Market Bread Co.",  "Sportman Cap & Bag"},
            },
            new Team
            {
                Name = "Angel Martinez",
                Role = "Senior Software Engineer",
                Description = @"Angel dedicates himself to ensuring quality and delivering value. Creative and passionate 
                about promoting creativity and innovation, he makes sure every project is just as impressive as he is! 
                Angel is a proactive, self-motivated, and creative problem solver.",
                ImgUrl = "template/images/team/martinez-small.webp",
                LinkedIn = "https://www.linkedin.com/in/angel-isaac-martinez-437589a1/",
                GithubUrl = "",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Juliana Galeano",
                Role = "Art Director",
                Description = @"Juliana can see the spark of potential everywhere. She is an expert in creating high-value 
                content, experiences, and emotions through audiovisual content with superb storytelling. ",
                ImgUrl = "template/images/team/juliana-small.webp",
                LinkedIn = "https://www.linkedin.com/in/juliana-galeano-garrido/",
                GithubUrl = "",
                Projects = new List<string>{ "Kati Sportcap & Bag", "Farm to Market Bread Co.",  "Sportman Cap & Bag", "Happy Volts"},

            },
            new Team
            {
                Name = "Danny Ruiz",
                Role = "Software Engineer",
                Description = @"Danny is proactive and intuitive, answering project needs before being asked. He focuses on software 
                and web application development. With his high level of creativity, a positive attitude, and desire to learn and improve, 
                Danny is ready for any project or challenge. He has a friendly and professional approach, resulting in many successful 
                projects for clients.",
                ImgUrl = "template/images/team/danny-small.webp",
                LinkedIn = "https://www.linkedin.com/in/danny-stev-ruiz/",
                GithubUrl = "https://github.com/danruiz01",
                Projects = new List<string>{ "Happy Volts", },
            },
            new Team
            {
                Name = "Sara Cabrera",
                Role = "Sales Specialist",
                Description = @"Sara likes to help companies reach their best version of themselves. Thanks to her skills and professional 
                experience, she has done this will companies and projects of all sizes and backgrounds. She is passionate about Marketing 
                and Business Analytics, and as a Sales Specialist, she has a record of success in boosting brands through tailored strategies.",
                ImgUrl = "template/images/team/sara-small.webp",
                LinkedIn = "https://www.linkedin.com/in/saracabrerao/",
                GithubUrl = "",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Bradley Bailey-Murray",
                Role = "Business Development",
                Description = @"Bradley takes concepts and turns them into reality through design, and code gets him up in the morning. 
                Utilizing his abilities to solve issues through planning and strategy drives him to continue learning and growing as a 
                designer and programmer. Bradley loves to watch projects come to life through the product cycle. He will make sure every 
                step of your project is smooth and successful every step of the way. ",
                ImgUrl = "template/images/team/bradley-small.webp",
                LinkedIn = "https://www.linkedin.com/in/bradley-bailey-murray-3823a053/",
                GithubUrl = "",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Kate Bradshaw",
                Role = "Graphic Designer",
                Description = @"Kate is a graphic designer with a background in creative writing. She takes a multifaceted approach to 
                communication and problem solving while adding new skills to her toolbelt. She rises to the occasion in every instance
                to make the client successful. ",
                ImgUrl = "template/images/team/kate-small.webp",
                LinkedIn = "https://www.linkedin.com/in/kateruthbradshaw/",
                GithubUrl = "",
                Projects = new List<string>{ "Kati Sportcap & Bag", "Farm to Market Bread Co.", "Sportman Cap & Bag"},
            }
        };
    }
}
