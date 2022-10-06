
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BlazorMovies.Server.Helpers;


using System.Net.Http;
using System.Text.Encodings.Web;

using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.OData;
using BlazorMovies.Base.Entidades;
using Microsoft.OData.ModelBuilder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMovies.Server
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
            //services.AddControllers();
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); //WebAssembly add

            services.AddMvc(options => options.EnableEndpointRouting = false) ;


            var oDataBuilder = new ODataConventionModelBuilder();

            services.AddOData();
            //OData Service
            /*
            oDataBuilder.EntitySet<Categoria>("Categoria");
            oDataBuilder.EntitySet<Livro>("Livros");
            var model = oDataBuilder.GetEdmModel();
            services.AddOData(opt => opt
            .AddModel("api",model).Count().Filter().OrderBy().Expand().Select());
           
            */
            services.AddRazorPages(); //WebAssembly add
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                               ServerVersion.AutoDetect(Configuration.GetConnectionString("DefaultConnection")) ));
             
            //  options.UseMySql(Configuration.GetConnectionString("LocalConnection")));//Teste No Banco Local
            // services.AddScoped<IFileStorageService>
            services.AddScoped<IFileStorageService, InAppStorageService>();
            services.AddHttpContextAccessor();// adiciona httpContextAcessor usado pelo UnAppStorageService
            
            services.AddAutoMapper(typeof(Startup)); //WebAssembly add
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlazorMovies.Server", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();//WebAssembly add
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlazorMovies.Server v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           

         

            app.UseHttpsRedirection();

            app.UseRouting();
           
           // app.UseAuthorization();
            app.UseBlazorFrameworkFiles(); //WebAssembly add
            app.UseStaticFiles();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); //WebAssembly add     
                endpoints.MapControllers();          
                endpoints.MapFallbackToFile("index.html"); //WebAssembly add     
                endpoints.EnableDependencyInjection();
            });
        }
    }
}
