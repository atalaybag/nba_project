using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Infrastructure.Tools;
using DataAccessLayer.Mappings;
using EntitiyLayer;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NbaWebApi.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NbaWebApi
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NbaWebApi", Version = "v1" });
            });
            services.AddScoped<INbaRepository<Players>, NbaRepository<Players>>();
            services.AddScoped<INbaRepository<Teams>, NbaRepository<Teams>>();
            
            services.AddScoped(typeof(IStoreRepository<>), typeof(StoreRepository<>));
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(opt => {
                opt.AddProfiles(new List<Profile>()
            {
                new ProductProfile(),
                new CategoryProfile()
            });
                });
            services.AddCors(opt =>
            {

                opt.AddPolicy("GlobalCors", config =>
                {
                    config.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();

                });

            });
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidAudience = JwtTokenSettings.Audince,
                    ValidIssuer = JwtTokenSettings.Issuer,
                    ClockSkew = TimeSpan.Zero,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenSettings.Key)),
                    ValidateIssuerSigningKey = true
                };
            });
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer("Server=DESKTOP-ITSS0P7; Database=NBALastDatabase; Trusted_Connection=true;").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            services.AddScoped<INbaService<Players>,NbaService<Players>>();
            services.AddScoped<INbaService<Teams>, NbaService<Teams>>();
           
            services.AddControllers().AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NbaWebApi v1"));
            }
            
            app.UseHttpsRedirection();
            
            app.UseRouting();
            app.UseCors("GlobalCors");
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
