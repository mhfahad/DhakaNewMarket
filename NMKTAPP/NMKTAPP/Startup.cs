using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NMKTAPP.BILL.BILL;
using NMKTAPP.BILL.BILL.Service;
using NMKTAPP.BILL.Interface;
using NMKTAPP.BILL.Interface.Service;
using NMKTAPP.DAL.DAL;
using NMKTAPP.DAL.DAL.Service;
using NMKTAPP.DAL.Interface;
using NMKTAPP.DAL.Interface.Service;
using NMKTAPP.DatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NMKTAPP
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
            services.AddDbContextPool<ProjectDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCors();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NMKTAPP", Version = "v1" });
            });
            services.AddScoped<DbContext, ProjectDbContext>();
            services.AddTransient<IUserInfoManager, UserInfoManager>();
            services.AddTransient<IUserInfoRepository, UserInfoRepository>();
            services.AddTransient<IServiceInfoManager, ServiceInfoManager>();
            services.AddTransient<IServiceInfoRepository, ServiceInfoRepository>();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NMKTAPP v1"));
            }
            app.UseStaticFiles( new StaticFileOptions
            { 
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath,"Images")),
                RequestPath = "/Images"
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });




            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}