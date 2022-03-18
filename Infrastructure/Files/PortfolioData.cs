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
                    "template/images/assets/gb/gentlebirth.webp",
                    "template/images/assets/gb/backoffice.webp",
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
                Reviews = new List<Reviews>
                {
                    new Reviews
                    {
                        Review = @"Great App. Easy to Understand. Love the ability to manually add
                        contractions although the entry method could use work.",
                        Reviewer = "Andrew Frimpong",
                        ReviewImgUrl = "/template/images/assets/gb/review1.webp"
                    },

                },
                Categories = new List<string>
                {
                    "Mobile Application"
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
                    "template/images/assets/fm/fertilemind.webp",
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
                Categories = new List<string> { "Mobile Application"}
            },
            new Portfolio
            {
                ProjectId = 1,
                Name = "Maxana",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Maxana is a company partner with a proven track record in the
                creation of new Fin tech Digital Transformation solutions and
                services to the market that create significant customer value
                enabled by technological expertise and an ecosystem
                of partners.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <div>

                   
				    <div class='mar-bottom-lg'>
					    <h2 class='heading mar-bottom-xs'>What is Stripe?</h2>
						    <p>
                                Stripe is a technology company that builds economic infrastructure for 
                                the internet. Their software helps businesses of all sizes to accept payments and 
                                manage their businesses online. Their software platform is used by millions of 
                                companies in over 120 countries.<br/><br/>

                                Stripe selected us to build their first-ever Stripe University cohort to obtain 
                                Stripe certification. We build a marketplace for Stripe where customers can easily 
                                access highly vetted, certified Stripe engineers and other technical resources that 
                                can help expand their payment capabilities. The platform uses friendly design to 
                                connect enterprises with qualified, certified Stripe-certified engineers and other 
                                technical resources that can readily and expertly implement Stripe integrations, 
                                reducing time to market and revenue.
                            </p>
					</div>
                   
                    <div class='mar-top-lg'>
                            <!-- start of icon-box -->
                            <div class='col-xs-12 col-sm-6 mar-bottom-sm icon-box'>
                                <span class='pe-7s-tools main-color icon add'></span>
                                <div class='holder'>
                                    <span class='title large'>Methodology</span>
                                        <p>
                                            We used a subset of TOGAF (The Open Group
                                            Architecture Framework) to define requirements, functions, services,
                                            capabilities, and technical components.
                                        </p>
                                </div>
                            </div><!-- end of icon-box -->
                            <!-- start of icon-box -->
                            <div class='col-xs-12 col-sm-6 mar-bottom-sm icon-box'>
                                <span class='pe-7s-browser main-color icon add'></span>
                                <div class='holder'>
                                    <span class='title large'>Design</span>
                                    <p>
                                       The capabilities were mapped to microservices using domaindriven
                                       design patterns like “ports and adapters,” which clarified the
                                       separation of concerns and enforced architecture. The infrastructure
                                       provisioning was 100% automated.
                                    </p>
                                </div>
                            </div><!-- end of icon-box -->
                            <!-- start of icon-box -->
                            <div class='col-xs-12 col-sm-6 mar-bottom-sm icon-box'>
                                <span class='pe-7s-helm main-color icon add'></span>
                                <div class='holder'>
                                    <span class='title large'>Management</span>
                                    <p>
                                        Agile/scrum was used to manage the
                                        development process.
                                    </p>
                                </div>
                            </div><!-- end of icon-box -->
                            <!-- start of icon-box -->
                            <div class='col-xs-12 col-sm-6 mar-bottom-sm icon-box'>
                                <span class='pe-7s-portfolio main-color icon add'></span>
                                <div class='holder'>
                                    <span class='title large'>Results</span>
                                    <p>
                                       A structured approach that facilitated easy
                                       onboarding and the processing of new data sets in short time. The
                                       new data sets powered financial instruments to trade revenue.
                                    </p>            
                                </div>
                            </div><!-- end of icon-box -->
                        </div>
                    </div>
                    <div class='mar-bottom-sm'>
					    <h2 class='heading mar-bottom-sm'>Stripe Implementation</h2>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Problem Statement</span>
						    <p>
                              A financial services company wanted to expedite and expand customer onboardingcapabilities leveraging an emerging low code platform to:
                            </p>

                            <ul>
                                <li>Enable multiple integrations</li>
                                <li>Transform and streamline the UX</li>
                                <li>Decrease onboarding by a factor of 10</li>
                                <li>Exponentially increase onboarding capacity</li>
                            </ul>
                        </div>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Technical Delivery</span>
                            <ul>
                                <li>Cloud-based New Account Opening low code platform integrated with an on-premises banking core</li>
                                <li>Complex integrations with FIS, Alacriti, iOvation, Mitek, and Plaid</li>
                                <li>New CICD DevOps platform with Datadog and Octopus implementation</li>
                            </ul>
                        </div>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Outcome</span>
                            <ul>
                                <li>Improved customer journey analytics, leveraging Google Analytics and MS PowerBI</li>
                                <li>30% increased customer conversion via streamlined UI</li>
                                <li>Improved ability to identify account fraud through integration with iOvation and Verafin</li>
                            </ul>
                        </div>
					</div>
                    <div class='mar-bottom-sm'>
					    <h2 class='heading mar-bottom-sm'>Data Science</h2>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Problem Statement</span>
						    <p>
                                A fintech needed to build a payments intelligence platform, including a unified system that consolidated risk, compliance, and investigative 
                                tooling with metrics enabling a single lens for all payment transactions for the purposes of fraud and compliance-based investigations.​
                            </p>
                        </div>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Technical Delivery</span>
                            <ul>
                                <li>Track metrics for compliance and operational tooling with Hive data pipelines and complex SQL queries</li>
                                <li>The platform was built on top of Apache opensource big data projects, e.g., Airflow, Superset, Tez, Hive, 
                                Presto, and integrated with Amazon EMR</li>
                            </ul>
                        </div>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Outcome</span>
                            <ul>
                                <li>Reduction in issues related to sanctions and fraudulent payments</li>
                                <li>Scalable and extensible tooling infrastructure that was flexible, configurable, customizable, and reusable​</li>
                                <li>Increased operational efficiency​</li>
                                <li>Improved accuracy​</li>
                            </ul>
                        </div>
					</div>
                    <div class='mar-bottom-sm'>
					    <h2 class='heading mar-bottom-sm'>Strategy</h2>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Problem Statement</span>
						    <p>
                                A fintech needed to create extraordinary user experiences across all digital banking channels for a truly omni-channel experience.
                            </p>
                        </div>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Technical Delivery</span>
                            <ul>
                                <li>Created Enterprise Service Bus (ESB)</li>
                                <li>Designed frontend UI</li>
                                <li>API integration to a common ESB</li>
                                <li>Minimal complexity from direct integrations to core</li>
                                <li>Widget based UI components easily modified based on best design principles/practices</li>

                            </ul>
                        </div>
                        <div class='mar-bottom-sm'>
                            <span class='subheading mar-bottom-xs'>Outcome</span>
                            <ul>
                                <li>Maxana’s recommendations drove the client’s vendor selection process</li>
                                <li>Negotiated vendor contracts​</li>
                                <li>Partnered with the vendors to initiate implementation​</li>
                                <li>Completed Design & Architecture of third-party integrations</li>
                            </ul>
                        </div>
					</div>
                </div>
        

"),
                ImgUrls = new List<string>{
                    "template/images/assets/maxana/maxana.webp",
                    //"template/images/assets/gb/templates.jpg",
                },
                Services = new List<string>
                {
                    "Production Support",
                    "API Development",
                    "Troubleshooting",
                    "Database Design",
                    "Server Management",
                    "Deployment Automation"
                },
                Technologies = new List<string>
                {
                    ".Net Core",
                    "Microsoft Azure",
                    "SQL Server"
                },
                Practices = new List<string>
                {
                    "User Research",
                    "Agile Development",
                    "Restful API",
                    "Data Management",
                    "Technical Discovery",
                    "Product Management",
                    "Cloud Hosting",
                    "Open Source Development"
                },
                Categories = new List<string>
                {
                    "API Development"
                }
            },
            new Portfolio
            {
                ProjectId = 1,
                Name = "Stripe",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Stripe is a technology company that builds economic infrastructure for 
                the internet. Their software helps businesses of all sizes to accept payments and 
                manage their businesses online. Their software platform is used by millions of 
                companies in over 120 countries.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <p>
                    Stripe selected us to build their first-ever Stripe University cohort to obtain 
                    Stripe certification. We build a marketplace for Stripe where customers can easily 
                    access highly vetted, certified Stripe engineers and other technical resources that 
                    can help expand their payment capabilities. The platform uses friendly design to 
                    connect enterprises with qualified, certified Stripe-certified engineers and other 
                    technical resources that can readily and expertly implement Stripe integrations, 
                    reducing time to market and revenue.
                </p>
                <div class='dots-image-2'>
                    <img class='img-responsive' src='template/images/assets/st/analysis.jpg'>
                    <div class='dots'></div>
                </div>
                <div style='padding-top: 2rem'>
                    <h5>
                        Methodology:
                    </h5>
                    <p>
                       We used a subset of TOGAF (The Open Group
                       Architecture Framework) to define requirements, functions, services,
                       capabilities, and technical components.
                    </p>
                    <h5>
                        Design:
                    </h5>
                    <p>
                       The capabilities were mapped to microservices using domaindriven
                       design patterns like “ports and adapters,” which clarified the
                       separation of concerns and enforced architecture. The infrastructure
                       provisioning was 100% automated.
                    </p>
                    <h5>
                        Management:
                    </h5>
                    <p>
                       Agile/scrum was used to manage the
                       development process.
                    </p>
                    <h5>
                        Results & Outcomes:
                    </h5>
                    <p>
                       A structured approach that facilitated easy
                       onboarding and the processing of new data sets in short time. The
                       new data sets powered financial instruments to trade revenue.
                    </p>
                    
                </div>
              "){
                },
                ImgUrls = new List<string>{
                    "template/images/assets/st/stripe.webp",
                    //"template/images/assets/gb/templates.jpg",
                },
                Services = new List<string>
                {
                    "Production Support",
                    "API Development",
                    "Troubleshooting",
                    "Database Design",
                    "Server Management",
                    "Deployment Automation"
                },
                Technologies = new List<string>
                {
                    ".Net Core",
                    "Microsoft Azure",
                    "SQL Server"
                },
                Practices = new List<string>
                {
                    "User Research",
                    "Agile Development",
                    "Restful API",
                    "Data Management",
                    "Technical Discovery",
                    "Product Management",
                    "Cloud Hosting",
                    "Open Source Development"
                },
                Categories = new List<string>
                {
                    "API Development"
                }
            },
            new Portfolio
            {
                ProjectId = 1,
                Name = "Advantage For Analysts",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Advantage for Analysts Inc provides modeling and analysis software
                and professional services for originating, trading and managing
                complex financial assets. Advantage’s solutions help clients
                retain a long-term competitive advantage through rapid insights,
                confident decision making, and improved risk management.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <p>
                    We create for Advantage for Analysts Inc a member-centered
                    web application that is not only conducive to their needs and
                    requirements, but also allows clients to communicate, review,
                    and interact as a teamwork. Our Restful APIs are responsible
                    for processing thousands of loans daily in a consortium-like
                    environment from multiple partners, allowing members to access
                    their loan information from anywhere in the world. Fintechfocused
                    APIs allow members to get loans from various partners
                    on the same platform, process loans instantly, create transfers
                    between different member accounts, lend against external
                    entities, and more.
                </p>
                <iframe style='border: 1px solid rgba(0, 0, 0, 0.1);' width='100%' height='800px' src='https://www.figma.com/proto/Mxc6FeoJNVX2PxMA8DbgzZ/AFA?embed_host=share&kind=&node-id=315%3A8230&starting-point-node-id=62%3A4121' allowfullscreen></iframe>

              "){
                },
                ImgUrls = new List<string>{
                    "template/images/assets/afa/afa.webp",
                },
                Services = new List<string>
                {
                    "Production Support",
                    "API Development",
                    "Troubleshooting",
                    "Database Design",
                    "Server Management",
                    "Deployment Automation"
                },
                Technologies = new List<string>
                {
                    ".Net Core",
                    "Microsoft Azure",
                    "SQL Server"
                },
                Practices = new List<string>
                {
                    "User Research",
                    "Agile Development",
                    "Restful API",
                    "Data Management",
                    "Technical Discovery",
                    "Product Management",
                    "Cloud Hosting",
                    "Open Source Development"
                },
                Categories = new List<string>
                {
                    "Web Development"
                }
            },
            //new Portfolio
            //{
            //    ProjectId = 1,
            //    Name = "Whistic",
            //    // Uses String Literal to make the string more readable on development. 
            //    Headline=@"Whistic simplifies how businesses assess, publish,
            //    and share security documentation with customers
            //    and vendors. The Whistic Vendor Security Network
            //    accelerates the vendor assessment process by
            //    enabling buyers to access and evaluate a vendor’s
            //    Whistic Profile. Additionally, Whistic facilitates zero-
            //    touch assessments via the Whistic Trust Catalog,
            //    which contains security information for more than
            //    35,000 businesses.",
            //    //Managing Body as a Markup string to be able to generate body more dynamically. 
            //    Body = new MarkupString(@""){
            //    },
            //    ImgUrls = new List<string>{
            //        "template/images/bg/bg1.jpg",
            //        //"template/images/assets/gb/templates.jpg",
            //    },
            //    Services = new List<string>
            //    {
            //        "Web development",
            //        "Web Design",
            //        "Mobile App Redesign",
            //        "Production Support",
            //        "API Development",
            //        "Troubleshooting",
            //        "Database Design",
            //        "Server Management",
            //        "Deployment Automation"
            //    },
            //    Technologies = new List<string>
            //    {
            //    },
            //    Practices = new List<string>
            //    {
            //    },
            //},
            new Portfolio
            {
                ProjectId = 1,
                Name = "Westcor",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Westcor, the largest privately held underwriter in the United States, is focused on 
                creating and promoting a culture where innovation is abundant at every level while at the same 
                time adhering to the strictest of compliance regulations and providing essential risk management 
                training. These attributes have secured Westcor as an industry leader in providing value-added 
                solutions to agents, lenders, and customers.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <p>
                    Westcor needed an app focused on UX design and a platform that could showcase its products. 
                    We developed an app using the React framework to provide a smooth workflow for users to 
                    interact with Westcor’s products. This app has helped secure Westcor as an industry leader 
                    in providing value-added solutions.
                </p>

                <iframe style='border: 1px solid rgba(0, 0, 0, 0.1);' width='100%' height='800px' src='https://www.figma.com/embed?embed_host=share&url=https%3A%2F%2Fwww.figma.com%2Fproto%2FmPvrUb7LgOU4ADmjVDJLGI%2Fwestcor%3Fnode-id%3D234%253A15836%26starting-point-node-id%3D152%253A10063' allowfullscreen></iframe>

              "){
                },
                ImgUrls = new List<string>{
                    "template/images/assets/westcor/westcor.webp",
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
                Categories = new List<string> { "Mobile Application"}
            },
            //new Portfolio
            //{
            //    ProjectId = 3,
            //    Name = "Techcu - TBC",
            //    // Uses String Literal to make the string more readable on development. 
            //    Headline=@"Techcu is a credit union that was founded in Silicon Valley, dedicated to the financial success of its members.
            //    Instead of maximizing profits to pay company stockholders, Techcu invests resources to deliver superior rates, lower fees,
            //    and outstanding service and member benefits.",
            //    //Managing Body as a Markup string to be able to generate body more dynamically. 
            //    Body = new MarkupString(@"<p>Techcu was interested in creating a member-centered website that provided members with the
            //    information they needed and represented their values as well. We have provided Techcu with a number of services, one of these
            //    is Restful Apis, which can process thousands of loans daily in a consortium-like environment from multiple partners. We created
            //    Fintech-focused APIs so that multiple partners can process loans, access member information, create transfers, and manage external
            //    loans using Azure logic apps and azure functions.</p>
            //    <div class='row' style='margin-bottom: 3rem'>
            //        <div class='col-md-12'>
            //            <p>
            //                Additionally, we have delivered extensive support
            //                for their legacy apps, improving code quality, creating development, staging and production environments as well. Our long-standing
            //                mission has been to position Techcu in the fintech industry, by providing enterprise services, APis, infrastructure that enhance
            //                their offerings to the fintech world, granting them multiple partnerships across automobile and solar industries with many more to
            //                come.
            //            </p> 
            //        </div>
            //        <div class='col-md-12'>
            //            <p>
            //                Digital Account Opening is a product for a credit union which offers 
            //                its customers to open an account with the union, without the customer 
            //                ever interacting without an official, everything is done online.
            //            </p> 
            //            <p>
            //                This application has the following features: 
            //            </p> 
            //            <ul>
            //                <li>
            //                    OFAC integrations.
            //                </li>
            //                <li>
            //                    Soft credit inquiry at the moment of opening an account.
            //                </li>
            //                <li>
            //                    Identity Detection.
            //                </li> 
            //                <li>
            //                    Electronic in house and external transfers at the moment of funding an account.
            //                </li>
            //                <li>
            //                    Move bank accounts from one bank to another.
            //                </li>
            //                <li>
            //                    Plaid Integration.
            //                </li>
            //            </ul>
            //        </div>
            //       </div>"
            //        ),
            //    ImgUrls = new List<string>{
            //        "template/images/assets/techcu/techcu2.webp",
            //        "template/images/assets/techcu/techcu1.webp",
            //        "template/images/assets/techcu/techcu3.webp",
            //        "template/images/assets/techcu/techcu4.webp"
            //    },
            //    Services = new List<string>
            //    {
            //        "Web development",
            //        "Web Design",
            //        "Production Support",
            //        "Mobile App Redesign",
            //        "API Development",
            //        "Database Design",
            //        "Server Management",
            //        "Deployment Automation"
            //    },
            //    Technologies = new List<string>
            //    {
            //        "Flutter / Dart",
            //        "Firebase",
            //        "SQL Server"

            //    },
            //    Practices = new List<string>
            //    {
            //        "User Research",
            //        "UX Design",
            //        "Agile Development",
            //        "Restful API",
            //        "Data Management",
            //        "Technical Discovery",
            //        "Mobile Design",
            //        "Product Management",
            //        "Cloud Hosting",
            //        "Open Source Development"
            //    },
            //},
            new Portfolio
            {
                ProjectId = 4,
                Name = "Happy Volts",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"HappyVolts is a clean tech company that makes all-in-one
                inverters to help people use natural resources wisely.
                The company was looking for help to structure its brand so that
                it would be more cohesive and memorable. During our strategic
                work, we analyzed their current status and proposed a new visual
                identity for them, seeking confidence, trust and intelligence.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>HappyVolts is a brand that has BTB and BTC customers. These
                groups have different profiles, besides having different languages
                and demographics. So, in order to improve the experience and
                turn HappyVolts leads into clients, we use Design Thinking tools to
                understand how our marketing and sales strategies should perform.</p>
                <h5>
                    CHALLENGE:
                </h5>
                <p>
                    Validate the different clients’ perception of the brand and
                    design different touchpoints and sale tools.
                </p>
                <h5>
                    ANALYSIS:
                </h5>
                <p>
                    We primarily conduct desk research, we perform a top-down evaluation,
                    and compare our findings with industry benchmarks. Next, we hold
                    interviews with current customers dividing the results according to BTB
                    and BTC. Once this phase was complete, we assemble a buyer persona
                    template and a costumer journey map containing useful information
                    about potential opportunities, touchpoints, sales tools and an analysis of
                    outside and inside actors.
                </p>
                <h5>
                    SOLUTION:
                </h5>
                <h6>
                    WEBSITE:
                </h6>
                <p>
                    Redesign the front-end of the WordPress e-commerce website. We improve our 
                    search engine optimization with strategic techniques that generate quality 
                    search engine traffic and visitors. Based on the SEO keywords we adjust all 
                    the copywriting and call to actions.<br/><br/>
                    We create a website page to add lead magnets, such as eBooks and HappyVolts mediakit.
                </p>
                <h6>
                    SOCIAL MEDIA:
                </h6>
                <p>
                    We create social media content for several platforms and manage their social 
                    media accounts such as Instagram, Facebook, and LinkedIn. 
                    We also create promotions and ads on those accounts.
                </p>
                <h5>
                    MARKETING:
                </h5>
                <p>
                    HappyVolts is interested in exhibiting at a variety of
                    international fairs. We have created POP and other
                    promotional material for them, including banners,
                    booth design and other items.
                </p>
                <div class='row' style='margin-bottom: 3rem'>
                    <div class='col-md-12'>
                        <p>
                           
                        </p> 
                    </div>
                    <div class='col-md-12'>
                        <p>
                          
                        </p> 
                    </div>
                   </div>"
                    ){
                },
                ImgUrls = new List<string>{
                    "template/images/assets/hv/hv.webp",
                    "template/images/assets/hv/hv2.webp"
                },
                Services = new List<string>
                {
                    "Web development",
                    "Web Design",
                    "Social Media Managment",
                    "Branding",
                    "Marketing Strategy",
                    "POP Material"
                },
                Technologies = new List<string>
                {
                    "HTML / CSS",
                    "Wordpress",
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
                Categories = new List<string> { "Marketing"}
            },
            new Portfolio
            {
                ProjectId = 5,
                Name = "Sportman Cap & Bag",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Sportsman Cap & Bag is a worldwide distributor of promotional
                merchandise. Has more than 85 years of experience in the cap
                industry, and continues to build upon a strong foundation,
                unique distribution network, and emerging opportunities.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>The company needed a website that could showcase its
                products online and provide an e-commerce interface for
                customers to purchase. Sportsman Cap & Bag also was looking
                for a marketing partner, to work from catalogs to display
                design, brand identity, social media content, web banners,
                and furthermore. We used marketing strategies to understand
                the market and stand out as a distributor. Also, we create a
                marketing plan to engage more customers and suppliers to
                work with.</p>
                "),
                ImgUrls = new List<string>{
                    "template/images/assets/sc/sportcap.webp",
                    "template/images/assets/sc/sc2.webp",
                },
                Services = new List<string>
                {
                    "Identity Design",
                    "Marketing Strategies",
                    "E-Blasts",
                    "Social Media Content",
                    "Website Banners",
                    "Catalogs",
                    "Web Design",
                    "Web Development"
                },
                Technologies = new List<string>
                {
                    "HTML / CSS",
                    "Wordpress",
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
                Categories = new List<string> { "Marketing"}

            },
            new Portfolio
            {
                ProjectId = 6,
                Name = "Kati Sportcap & Bag",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Kati Sportcap & Bag is an established distributor of promotional
                products, caps, and bags, operated in Houston, Texas. For
                more than 35 years, Kati Sportcap & Bag has serviced the
                promotional products and decorated apparel industry. It now
                carries 17 brands, 326 styles, and over 2,800 stock-keeping
                units.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Kati Sportcap & Bag sought a website partner to create an
                e-commerce site that would showcase its products and provide
                a means of purchasing them. The company also needed a
                distributor to work with on marketing, brand identity, display
                design, social media content, and web banners. We also
                helped the company formulate a marketing plan that would
                help increase sales volume as well as open up opportunities
                for sourcing new suppliers.</p>
                "),
                ImgUrls = new List<string>{
                    "template/images/assets/sc/ksc1.webp",
                    "template/images/assets/sc/sportcap.webp",
                },
                Services = new List<string>
                {
                    "Identity Design",
                    "Marketing Strategies",
                    "E-Blasts",
                    "Social Media Content",
                    "Website Banners",
                    "Catalogs",
                    "Web Design",
                    "Web Development"
                },
                Technologies = new List<string>
                {
                    "HTML / CSS",
                    "Wordpress",
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
                Categories = new List<string> { "Marketing"}
            },
            new Portfolio
            {
                ProjectId = 8,
                Name = "Farm to Market Bread Co.",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Farm to Market Bread Co. is a company that answers 
                the need for fresh bread baked from quality ingredients. Farm 
                to Market Bread is the largest fresh bread bakery in the area 
                of Kansas City, employing 65 people who bake, pack, and deliver 
                fresh bread to 200 grocery stores and restaurants.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Farm to Market Bread Company engaged 
                us because they needed an array of services including collateral 
                and sales promotion, marketing campaigns, display design, logo, 
                and identity development.</p>"),
                ImgUrls = new List<string>{
                    "template/images/assets/ftmb/ftmb.webp",
                    "template/images/assets/ftmb/ftmb2.webp",
                },
                Services = new List<string>
                {
                    "Collateral and Sales Promotion",
                    "Marketing Campaings",
                    "Display Design",
                    "Logo",
                    "Identity Design",
                },
                Technologies = new List<string>
                {
                    "HTML / CSS",
                    "Wordpress",
                },
                Practices = new List<string>
                {
                    "UX Design",
                    "Product Management",
                },
                Categories = new List<string> { "Marketing"}
            }
        };
    }
}
