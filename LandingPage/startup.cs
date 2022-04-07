using LandingPage.Data;
using Microsoft.AspNetCore.ResponseCompression;
using Newtonsoft.Json.Serialization;
using SendGrid.Extensions.DependencyInjection;

namespace LandingPage
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration.BuildCustomConfiguration();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Fastest);
            services.AddResponseCompression();
            services.AddMvc(options => options.EnableEndpointRouting = false)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                })
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.SuppressModelStateInvalidFilter = true;
                });

            services.AddRazorPages();
            services.AddServerSideBlazor(o => o.DetailedErrors = true);

            services.AddSendGrid(options =>
            {
                options.ApiKey = Configuration["NativoSignUpFormApiKey"];
            });

            services.AddOptions<SendGridOptions>().Configure(options =>
            {
                options.NewsletterContactsListId = Configuration["SendGrid:NewsletterContactsListId"];
                options.LeadsContactsListId = Configuration["SendGrid:LeadsContactsListId"];
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Append(Microsoft.Net.Http.Headers.HeaderNames.AcceptEncoding, "gzip, compress, br");
                await next();
            });

            app.UseHttpsRedirection();
            app.UseResponseCompression();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseMvcWithDefaultRoute();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
