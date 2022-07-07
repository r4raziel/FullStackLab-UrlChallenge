using hey_url_challenge_code_dotnet.Exceptions;
using hey_url_challenge_code_dotnet.Models;
using HeyUrlChallengeCodeDotnet.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HeyUrlChallengeCodeDotnet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUrlRepository, UrlRepository>();
            services.AddTransient<ExceptionHandlerMiddleware>();
            services.AddBrowserDetection();
            services.AddControllersWithViews()
                .AddXmlSerializerFormatters()
                .AddXmlDataContractSerializerFormatters()
                .AddJsonOptions(
                    jsonOptions => jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null
                ); ;
            //services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase(databaseName: "HeyUrl"));

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(
               Configuration.GetConnectionString("DbConnection")));

            services.AddMvc(options =>
            {
                options.ReturnHttpNotAcceptable = true;
                options.EnableEndpointRouting = false;

            }).AddXmlSerializerFormatters().AddXmlDataContractSerializerFormatters();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApiDemo", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApiDemo v1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/NotFound";                    
                    await next();
                }
                else if (context.Response.StatusCode == 500)
                {
                    context.Request.Path = "/InternalServer";
                    await next();
                }
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();           
            app.UseRouting();
            app.UseMiddleware<ExceptionHandlerMiddleware>();
            app.UseAuthorization();
            // app.UseMvc();
           // app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            /*app.UseEndpoints(endpoints =>
            {
               endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

               endpoints.MapControllers();
               endpoints.MapRazorPages();
            });*/

            using var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<ApplicationContext>();
            context.Database.EnsureCreated();
        }
    }
}
