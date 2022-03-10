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
                Description = @"Hector is a software developer with a wealth of practical experience. 
                He’s fearless, up for a challenge and full of ideas. He can create the kind of software 
                your organization needs to stay in front of your competitors. Hector loves to deliver effective, 
                reliable services that meet the needs of any project, and he loves to see his ideas become real.",
                ImgUrl = "template/images/team/hector.webp",
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
                ImgUrl = "template/images/team/jose.webp",
                LinkedIn = "https://www.linkedin.com/in/joecolon/",
                GithubUrl = "https://github.com/jvelezc",
                Projects = new List<string>{ "TechCU", "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Angel Ramos",
                Role = "Software Engineer",
                Description = @"Angel enjoys learning and staying on top of the latest trends in writing 
                code. He specializes in NativeScript and APIs for mobile healthcare applications. He’s 
                dedicated to ensuring quality and delivering value on every project.",
                ImgUrl = "template/images/team/ramos.webp",
                LinkedIn = "https://www.linkedin.com/in/angel-ramos-5a6a52a2/",
                GithubUrl = "https://github.com/joey0xx",
                Projects = new List<string>{ "TechCU"},
            },
            new Team
            {
                Name = "Arnaldo Rodriguez",
                Role = "Software Engineer",
                Description = @"Focused and passionate about creating quality products, that involve a great 
                design as well as great code. He likes to follow the best practices and latest design patterns. 
                Arnaldo is a professional that promotes and empowers creativity and a healthy work environment.",
                ImgUrl = "template/images/team/arnaldo.webp",
                LinkedIn = "https://www.linkedin.com/in/arnaldo-rodriguez-1445b811b/",
                GithubUrl = "https://github.com/arodriguezgb",
                Projects = new List<string>{ "Gentlebirth", "Fertilemind" },
            },
            new Team
            {
                Name = "Cristian Amaro",
                Role = "Software Engineer",
                Description = @"Cristian knows that website are about people, he is dedicated to full-stack web 
                development. He focuse on designing modern web-based solutions and is experience on development 
                life-cycle of team-based web projects.",
                ImgUrl = "template/images/team/amaro.webp",
                LinkedIn = "https://www.linkedin.com/in/cristian-amaro-burgos-64815816a/",
                GithubUrl = "https://github.com/camaro24max",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Marie Fitch",
                Role = "COO",
                Description = @"Marie is a Creative specialist dedicated to finding original 
                design solutions to everyday life. Specialist in sales and marketing, facilitating 
                businesses to exceed sales objectives. ",
                ImgUrl = "template/images/team/marie.webp",
                LinkedIn = "https://www.linkedin.com/in/mariefitch/",
                GithubUrl = "",
                Projects = new List<string>{  },
            },
            new Team
            {
                Name = "Angel Martinez",
                Role = "Senior Software Engineer",
                Description = @"Angel is always dedicated to ensuring quality and delivering value. 
                Creative and passionate in promoting creativity and innovation. Proactive, 
                self-motivated, and creative problem solver.",
                ImgUrl = "template/images/team/martinez.webp",
                LinkedIn = "https://www.linkedin.com/in/angel-isaac-martinez-437589a1/",
                GithubUrl = "",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Juliana Galeano",
                Role = "Art Director",
                Description = @"Juliana has the ability to see the spark of potential everywhere. She is 
                an expert in creating high-value content, experiences, and emotions through audiovisual 
                content and storytelling. Juliana combines imagination with a desire for practical solutions 
                using human-centered and design thinking tools.",
                ImgUrl = "template/images/team/juliana.webp",
                LinkedIn = "https://www.linkedin.com/in/juliana-galeano-garrido/",
                GithubUrl = "",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Danny Ruiz",
                Role = "Software Engineer",
                Description = @"Danny is a proactive and intuitive person, answering project needs before being
                asked. He is focused on software and web application development, with a high level of creativity, 
                a positive attitude, and a desire to learn and improve day by day. He is friendly and professional 
                approach has resulted in many successful projects for clients of all sizes.",
                ImgUrl = "template/images/team/danny.webp",
                LinkedIn = "https://www.linkedin.com/in/danny-stev-ruiz/",
                GithubUrl = "https://github.com/danruiz01",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Sara Cabrera",
                Role = "Sales Specialist",
                Description = @"Sara likes to help companies reach their best version, thanks to her skills 
                and professional experience. She is passionate about Marketing and Business Analytics. As a 
                Sales Specialist, she has a record of success in boosting brands through tailored strategies.",
                ImgUrl = "template/images/team/sara.webp",
                LinkedIn = "https://www.linkedin.com/in/saracabrerao/",
                GithubUrl = "",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Bradley Bailey-Murray",
                Role = "Business Development",
                Description = @"Taking concepts and turning them into reality through design and code is what 
                gets him up in the morning. Having the opportunity to utilize his abilities to solve issues 
                and constraints through planning and strategy drives him to continue to learn and grow as a 
                designer and programmer on a daily basis. He loves to watch projects come to life through the 
                product cycle.",
                ImgUrl = "template/images/team/bradley.webp",
                LinkedIn = "https://www.linkedin.com/in/bradley-bailey-murray-3823a053/",
                GithubUrl = "",
                Projects = new List<string>{ },
            },
            new Team
            {
                Name = "Kate Bradshaw",
                Role = "Graphic Designer",
                Description = @"Kate is a graphic designer with a background in creative writing. She takes a 
                multifaceted approach to communication and problem solving, and is always looking to add new 
                skills to her toolbelt.",
                ImgUrl = "template/images/team/kate.webp",
                LinkedIn = "https://www.linkedin.com/in/kateruthbradshaw/",
                GithubUrl = "",
                Projects = new List<string>{ },
            }
        };
    }
}
