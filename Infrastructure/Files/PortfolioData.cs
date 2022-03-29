using LandingPage.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace LandingPage.Infrastructure.Files
{
    public class PortfolioData
    {
        public List<Portfolio> portfolio = new()
        {
            new Portfolio
            {
                ProjectId = 1,
                Name = "Gentlebirth",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"GentleBirth is an App that takes pregnant women from fear to confidence
                in their childbirth preparation. Mindfulness, breathing techniques, affirmations, and hypnosis are
                combined with evidence-based research and technology to provide a holistic birthing experience.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Gentlebirth was looking for improved design, modified structure, and refactored implementation of multiple React components
                within a responsive web app that thousands of users access daily. Changes needed to be made based on business requirements, user requests, and customer feedback. 
                Additionally, they were looking to streamline the process of managing sessions, journeys, playlists, and promotions.</p>"),
                HeaderImageUrl =  "template/images/assets/gb/gentlebirth-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/gb/gentlebirth.webp",
                    "template/images/assets/gb/backoffice.webp",
                    //"template/images/assets/gb/templates.jpg",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/gb/gentlebirth-small.webp"
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
                },
                Challenge = @"Gentlebirth was looking for a better design, structure, and responsive web app. Additionally,
                they were looking to streamline the process of managing sessions, journeys, playlists, and promotions.",
                Solution = @"We refactored the implementation of multiple React components within a responsive web app, 
                accessed by thousands of users, based on business requirements, user requests, and customer feedback.",           
                Outcome = @"We create a user-friendly app with a website landing page and the back office to administrate 
                the Gentlebirth App. We also have created and planned social media content to promote the app, blogs, and masterclass."
            },
            new Portfolio
            {
                ProjectId = 2,
                Name = "TechCU",
                // Uses String Literal to make the string more readable on development. 
                Headline = @"TechCU is a credit union that was founded in Silicon Valley, dedicated to the financial success of its members.
                Instead of maximizing profits to pay company stockholders, TechCU invests resources to deliver superior rates, lower fees,
                and outstanding service and member benefits.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>TechCU was interested in creating a member-centered website that provided members with the 
                information they needed and represented their values. We have provided TechCU with several services; one of these is Restful 
                APIs, which can process thousands of loans daily in a consortium-like environment from multiple partners. We created FinTech 
                focused APIs so that numerous partners can process loans, access member information, initiate transfers, and manage external loans using Azure logic apps and Azure functions.</p>
                <div class='row' style='margin-bottom: 3rem'>
                    <div class='col-md-12'>
                        <p>
                           Additionally, we have delivered extensive support for their legacy apps, improving code quality, creating development,
                           staging, and production environments. Our long-standing mission has been to position TechCU in the FinTech industry by
                           providing enterprise services, APIs, infrastructure that enhances their offerings to the FinTech world by granting them 
                           multiple partnerships across automobile and solar industries with many more to come.
                        </p> 
                    </div>
                    <div class='col-md-12'>
                        <p>
                           Digital Account Opening is a product for a credit union that offers its customers a way to open an account with the union
                           without the customer ever interacting with an actual human being or going into a bank branch. Absolutely everything is done 
                           online at the user’s convenience, for example, electronic in-house and external transfers when funding an account.
                        </p> 
                        <p>
                            This application has the following features: 
                        </p> 
                        <ul>
                            <li>
                                OFAC integrations.
                            </li>
                            <li>
                                Soft credit inquiry at the moment of opening an account.
                            </li>
                            <li>
                                Identity Detection.
                            </li> 
                            <li>
                                Electronic in house and external transfers at the moment of funding an account.
                            </li>
                            <li>
                                Move bank accounts from one bank to another.
                            </li>
                            <li>
                                Plaid Integration.
                            </li>
                        </ul>
                    </div>
                   </div>"
                    ),
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/techcu/techcu-small.webp"
                },
                ImgUrls = new List<string>
                {
                    "template/images/assets/techcu/techcu.webp",
                    "template/images/assets/techcu/techcu_mobile.webp",
                },
                Services = new List<string>
                {
                    "Web development",
                    "Web Design",
                    "Production Support",
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
                Categories = new List<string> 
                { 
                    "Web Development" 
                },
                Challenge = @"Techcu was interested in creating a member-centered website that provided members with the information they needed and represented 
                their values as well.",
                Solution = @"We have provided Techcu with a number of services, one of these is Restful Apis, which can process thousands of loans daily in a 
                consortium-like environment from multiple partners. ",
                Outcome = @"Additionally, we have delivered extensive support for their legacy apps, improving code quality, creating development, staging, and 
                production environments as well. "
            },
            new Portfolio
            {
                ProjectId = 3,
                Name = "Advantage For Analysts",
                // Uses String Literal to make the string more readable on development. 
                Headline = @"Advantage for Analysts Inc provides modeling and analysis software
                and professional services for originating, trading and managing
                complex financial assets. Advantage’s solutions help clients
                retain a long-term competitive advantage through rapid insights,
                confident decision making, and improved risk management.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <p>
                   We created for Advantage for Analysts Inc a member-centered web application that is conducive to their needs and requirements and allows clients 
                   to communicate, review, and interact as a team. Our Restful APIs are responsible for processing thousands of loans daily in a consortium-like environment 
                   from multiple partners, allowing members to access their loan information anywhere. FinTech focused APIs enable members to get loans from various partners 
                   on the same platform, process loans instantly, create transfers between different member accounts, lend against external entities, etc.
                </p>
                <iframe style='border: 1px solid rgba(0, 0, 0, 0.1);' width='100%' height='800px' src='https://www.figma.com/proto/Mxc6FeoJNVX2PxMA8DbgzZ/AFA?embed_host=share&kind=&node-id=315%3A8230&starting-point-node-id=62%3A4121' allowfullscreen></iframe>

              ")
                {
                },
                HeaderImageUrl = "template/images/assets/afa/afa-header.webp",
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/afa/afa-small.webp",
                },
                ImgUrls = new List<string>
                {
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
                },
                Challenge = @"Advantage for Analysts Inc. was looking for analysis software and professional services for originating, trading, and 
                managing complex financial assets as a group.",
                Solution = @"We create for Advantage for Analysts Inc a member-centered web app that is not only conducive to their needs and requirements, 
                but also allows clients to communicate, review, and interact as a team.",
                Outcome = @"Our Restful APIs are responsible for processing thousands of loans daily in a consortium-like environment from multiple partners, 
                allowing members to access their loan information from anywhere in the world. "
            },
            new Portfolio
            {
                ProjectId = 4,
                Name = "Fertilemind",
                // Uses String Literal to make the string more readable on development. 
                Headline=@"Fertilemind is an app that approaches infertility by intentional
                mental activity improving reproductive health cycles. It combines
                guidance from the Award Winning FertileMind Program with an
                interface to make your fertility journey effective and stress-free.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Fertilemind needed an App focused on UX and a clean and easy-to-use platform. We developed a user interface to 
                showcase its apps and provide a tool for users to interact with the app more easily than before. We decided to build a UI based on the React 
                framework. </p>"),
                HeaderImageUrl =  "template/images/assets/fm/fertile-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/fm/fertilemind.webp",
                    "template/images/assets/fm/fertile-header.webp",

                    //"template/images/assets/gb/templates.jpg",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/fm/fertilemind-small.webp"
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
                Categories = new List<string> { "Mobile Application"},
                Challenge = @"Fertilemind needed an App focused on UX and a clean and easy-to-use platform.",
                Solution = @"We decided to build UI-based and human-centered research on the React framework, which was already being 
                used in the backend.",
                Outcome = @"We create an app focused on UX with a website landing page to showcase the app."
            },
            new Portfolio
            {
                ProjectId = 5,
                Name = "Happy Volts",
                // Uses String Literal to make the string more readable on development. 
                Headline = @"HappyVolts is a clean tech company that makes all-in-one
                inverters to help people use natural resources wisely.
                The company was looking for help to structure its brand so that
                it would be more cohesive and memorable. During our strategic
                work, we analyzed their current status and proposed a new visual
                identity for them, seeking confidence, trust and intelligence.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>HappyVolts is a brand that has BTB and BTC customers. These groups have different profiles 
                and have various languages and demographics to complicate matters. So, to improve the experience and turn HappyVolts leads 
                into clients, we used Design Thinking tools to understand how our marketing and sales strategies should perform. </p>
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
                   We primarily conduct desk research, perform a top-down evaluation, and compare our findings with industry benchmarks. 
                   Next, we hold interviews with current customers dividing the results according to BTB and BTC. Once this phase was 
                   complete, we assembled a buyer persona template and a customer journey map containing helpful information about potential 
                    opportunities, touchpoints, sales tools, and analysis of outside and inside actors.

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
                   We create social media content for several platforms and manage their social media accounts such as Instagram, 
                   Facebook, and LinkedIn. We also create promotions and advertisements on those accounts.

                </p>
                <h5>
                    MARKETING:
                </h5>
                <p>
                   HappyVolts is interested in exhibiting at a variety of international fairs. We have created POP and other promotional
                   material for them, including banners, booth designs, and other marketing and promotional items. 
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
                    )
                {
                },
                HeaderImageUrl = "template/images/assets/hv/happyvolts-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/hv/hv.webp",
                    "template/images/assets/hv/hv2.webp"
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/hv/hv-small.webp"
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
                Categories = new List<string> { "Marketing" },
                Challenge = @"The company was looking for help to structure its brand so that it would be more cohesive and memorable.",
                Solution = @"During our strategic work, we analyzed their current status and proposed a new visual identity for them, seeking confidence, trust, 
                and intelligence.",
                Outcome = @"We redesign the front-end of the WordPress e-commerce website. We improve our search engine optimization with strategic techniques
                that generate quality search engine traffic and visitors."
            },
            new Portfolio
            {
                ProjectId = 6,
                Name = "Maxana",
                // Uses String Literal to make the string more readable on development. 
                Headline= @"Maxana is a company partner with a proven track record in creating new FinTech Digital Transformation solutions and services to the 
                market that make significant customer value enabled by technological expertise and an ecosystem of partners.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <div>

                   
				    <div class='mar-bottom-lg'>
						    <p>
                            Maxana is a premier staffing solution focused on the technology sector. They built tools to organize talent and provide a conduit 
                            between employers and contractors in the payment space.
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
                                       The capabilities were mapped to microservices using domain-driven
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
                              A financial services company wanted to expedite and expand customer onboarding capabilities leveraging an emerging low code platform to:
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
                               A FinTech needed to build a payments intelligence platform, including a unified system that consolidated risk, compliance, and investigative
                               tooling with metrics enabling a single lens for all payment transactions for fraud and compliance-based investigations.​
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
                                <li>Scalable and extendable tooling infrastructure was flexible, configurable, customizable, and reusable​</li>
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
                               A FinTech needed to create extraordinary user experiences across all digital banking channels for a truly omnichannel experience.
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
                HeaderImageUrl =  "template/images/assets/maxana/maxana-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/maxana/maxana.webp",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/maxana/maxana-small.webp"
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
                },
                Challenge = @"Stripe selected us to build their first-ever Stripe University cohort to obtain Stripe certification. Currently, 
                most Stripe customers cannot access Stripe certified architects and engineers to integrate their businesses with the Stripe platform 
                quickly, with an estimated backlog of $100M in opportunity cost transaction revenue.",
                Solution = @"We build a marketplace for Stripe where customers can easily access highly vetted, certified Stripe engineers and other 
                technical resources that can help expand their payment capabilities.  We used a subset of TOGAF (The Open Group Architecture Framework) 
                to define requirements, functions, services, capabilities, and technical components.",
                Outcome = @"A structured approach that facilitated easy onboarding. The platform uses a friendly design to connect enterprises with 
                qualified, certified Stripe-certified engineers and other technical resources that can readily and expertly implement Stripe integrations, 
                reducing time to market and revenue."
            },
            new Portfolio
            {
                ProjectId = 7,
                Name = "Stripe",
                // Uses String Literal to make the string more readable on development. 
                Headline= @"The main goal of this project was to configure a production-ready instance of elastic search, wireframes, mocks ups, and architecture 
                to connect people seeking meaningful work with the right opportunities available for them.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <p>
                   The platform uses a friendly design to connect enterprises with qualified and certified Stripe engineers and other technical resources that can 
                   readily and expertly implement integrations while reducing time to market and generating revenue.
                </p>
             
                <div >
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
                       The capabilities were mapped to microservices using domain-driven
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
              ")
                {
                },
                HeaderImageUrl =  "template/images/assets/st/stripe-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/st/stripe.webp",
                    "template/images/assets/st/stripe-header.webp",

                    //"template/images/assets/gb/templates.jpg",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/st/stripe-small.webp"
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
                },
                Challenge = @"Stripe selected us to build their first-ever Stripe University cohort to obtain 
                Stripe certification. Currently, most Stripe customers cannot access Stripe certified architects
                and engineers to integrate their businesses with the Stripe platform quickly, with an estimated 
                backlog of $100M in opportunity cost transaction revenue.",
                Solution = @"We build a marketplace for Stripe where customers can easily access highly vetted, 
                certified Stripe engineers and other technical resources that can help expand their payment capabilities.  
                We used a subset of TOGAF (The Open Group Architecture Framework) to define requirements, functions,
                services, capabilities, and technical components.",
                Outcome = @"A structured approach that facilitated easy onboarding. The platform uses a friendly design 
                to connect enterprises with qualified, certified Stripe-certified engineers and other technical resources 
                that can readily and expertly implement Stripe integrations, reducing time to market and revenue."
            },
            
            new Portfolio
            {
                ProjectId = 8,
                Name = "Westcor",
                // Uses String Literal to make the string more readable on development. 
                Headline= @"Westcor, the largest privately held underwriter in the United States, is focused on creating and 
                promoting a culture where innovation is abundant at every level while adhering to the strictest of compliance regulations 
                and providing essential risk management training. These attributes have secured Westcor as an industry leader in providing 
                value-added solutions to agents, lenders, and customers.",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"
                <p>
                    Westcor needed an app focused on UX design and a platform that could showcase its products. 
                    We developed an app using the React framework to provide a smooth workflow for users to 
                    interact with Westcor’s products. This app has helped secure Westcor as an industry leader 
                    in providing value-added solutions.
                </p>

                <iframe style='border: 1px solid rgba(0, 0, 0, 0.1);' width='100%' height='800px' src='https://www.figma.com/embed?embed_host=share&url=https%3A%2F%2Fwww.figma.com%2Fproto%2FmPvrUb7LgOU4ADmjVDJLGI%2Fwestcor%3Fnode-id%3D234%253A15836%26starting-point-node-id%3D152%253A10063' allowfullscreen></iframe>

              ")
                {
                },
                HeaderImageUrl =  "template/images/assets/westcor/westcor-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/westcor/westcor.webp",
                    //"template/images/assets/gb/templates.jpg",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/westcor/westcor-small.webp"
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
                Categories = new List<string> { "Mobile Application"},
                Challenge = @"Westcor needed an app focused on UX design and a platform that could showcase its products.",
                Solution = @"We developed an app using the React framework to provide a smooth workflow for users to interact with Westcor’s products.",
                Outcome = @"This app has helped secure Westcor as an industry leader in providing value-added solutions."
            },
            new Portfolio
            {
                ProjectId = 9,
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
                HeaderImageUrl =  "template/images/assets/sc/sportsman-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/sc/sportcap.webp",
                    "template/images/assets/sc/sc2.webp",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/sc/sportcap-small.webp"
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
                Categories = new List<string> { "Marketing"},
                Challenge = @"The company needed a website that could showcase its products online and provide an e-commerce interface for customers to purchase. ",
                Solution = @"We used marketing strategies to understand the market and stand out as a distributor. Also, we create a marketing plan to engage 
                more customers and suppliers to work with.",
                Outcome = @"We have developed from catalogs to display design, brand identity, social media content, web banners, and furthermore."

            },
            new Portfolio
            {
                ProjectId = 10,
                Name = "Kati Sportcap & Bag",
                // Uses String Literal to make the string more readable on development. 
                Headline= @"Kati Sportcap & Bag is an established distributor of promotional products, caps, and bags in Houston, Texas. For more than 35 years, Kati Sportcap 
                & Bag has serviced the promotional products and decorated apparel industry. It now carries 17 brands, 326 styles, and over 2,800 stock-keeping units.",
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
                HeaderImageUrl =  "template/images/assets/sc/kati-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/sc/ksc1.webp",
                    "template/images/assets/sc/sportcap.webp",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/sc/ksc1-small.webp"
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
                Categories = new List<string> { "Marketing"},
                Challenge = @"Kati Sportcap & Bag sought a website partner to create an e-commerce site that would showcase its products and provide a means 
                of purchasing them.",
                Solution = @"We formulate a marketing plan that would help increase sales volume as well as open up opportunities for sourcing new suppliers.",
                Outcome = @"Successful campaigns, new brand identity, display design, social media content, and web banners."
            },
            new Portfolio
            {
                ProjectId = 11,
                Name = "Farm to Market Bread Co.",
                // Uses String Literal to make the string more readable on development. 
                Headline= @"Farm to Market Bread Co. is a company that answers the need for fresh bread baked from quality ingredients. Farm to Market Bread is 
                the largest fresh bread bakery in Kansas City, employing 65 people who bake, pack, and deliver fresh bread to 200 grocery stores and restaurants. ",
                //Managing Body as a Markup string to be able to generate body more dynamically. 
                Body = new MarkupString(@"<p>Farm to Market Bread Company came to us because they needed various services, including collateral and sales promotion, 
                marketing campaigns, display designs, a logo, and identity development.</p>"),
                HeaderImageUrl =  "template/images/assets/ftmb/farm-header.webp",
                ImgUrls = new List<string>
                {
                    "template/images/assets/ftmb/ftmb.webp",
                    "template/images/assets/ftmb/ftmb2.webp",
                },
                SmallImgUrls = new List<string>
                {
                    "template/images/assets/ftmb/ftmb-small.webp"
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
                Categories = new List<string> { "Marketing"},
                Challenge = @"Farm to Market Bread Company engaged us because they needed an array of marketing services to increase their awareness.",
                Solution = @"We offer them different marketing and publicity services, each using a different strategy to reach their target audience. 
                We even create marketing and promotional plans.",
                Outcome = @"We develop sales promotion, marketing campaigns, display design, logo, and identity development."
            },
        
            //new Portfolio
            //{
            //    ProjectId = 12,
            //    Name = "Whistic",
            //    // Uses String Literal to make the string more readable on development. 
            //    Headline = @"Whistic simplifies how businesses assess, publish,
            //    and share security documentation with customers
            //    and vendors. The Whistic Vendor Security Network
            //    accelerates the vendor assessment process by
            //    enabling buyers to access and evaluate a vendor’s
            //    Whistic Profile. Additionally, Whistic facilitates zero-
            //    touch assessments via the Whistic Trust Catalog,
            //    which contains security information for more than
            //    35,000 businesses.",
            //    //Managing Body as a Markup string to be able to generate body more dynamically. 
            //    Body = new MarkupString(@"")
            //    {
            //    },
            //    ImgUrls = new List<string>{
            //        "template/images/assets/whistic/whistich-cv.webp",
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
            //    Challenge = @"Whistic was looking for a website that simplifies how businesses assess, publish, and share security documentation with customers and vendors.",
            //    Solution = @"We help the Whistic Vendor Security Network to accelerate the vendor assessment process by enabling buyers to access and evaluate a vendor’s
            //    Whistic Profile.",
            //    Outcome = @"Whistic now facilitates zero-touch assessments via the Whistic Trust Catalog, which contains security information for more than 35,000 businesses."
            //},
        };
    }
}
