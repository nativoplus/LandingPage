using Microsoft.AspNetCore.ResponseCompression;

namespace LandingPage
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Fastest);
            services.AddResponseCompression();
            services.AddRazorPages();
            services.AddServerSideBlazor(o => o.DetailedErrors = true);
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

            //app.Use(async (context, next) =>
            //{
            //    context.Response.Headers.Add("Content-Security-Policy", "base-uri 'self';block-all-mixed-content;default-src 'self';font-src 'self' https://fonts.gstatic.com/;object-src 'none';script-src 'nonce-NativoPlus' 'strict-dynamic' 'unsafe-inline' https:;style-src 'self' https://cdnjs.cloudflare.com/ https://fonts.googleapis.com/ 'unsafe-inline' https:;upgrade-insecure-requests;");
            //    await next();
            //});

            app.UseHttpsRedirection();
            app.UseResponseCompression();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
