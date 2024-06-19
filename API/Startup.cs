using ApplicationCore.Interfaces.IServices;
using ApplicationCore.Mapper;
using ApplicationCore.Services;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
namespace API
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


            services.AddSession( );
            services.AddDistributedMemoryCache();
        
        services.AddScoped<DbContext, MedicDbContext>();
            services.AddScoped<Mapper>();
            services.AddCors(options =>
            {

                options.AddPolicy("AllowFrontend",
                    builder => builder
                        .WithOrigins("http://localhost:3000") // Add your frontend URL here
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials());

            });
            services.AddAutoMapper(typeof(ObjectMapper));
            #region ADD Scoped Repository 
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IMedicalStateRepository, MedicalStateRepository>();
            services.AddScoped<IMedicineRepository, MedicineRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();

            #endregion ADD Scope dRepository

            #region ADD Scoped  Services
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IMedicalStateService, MedicalStateService>();
            services.AddScoped<IMedicineService, MedicineService>();
            services.AddScoped<IIngredientService, IngredientService>();
            #endregion ADD Scoped  Services

            #region ADD DB Context
            services.AddDbContext<MedicDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                ;
            }
                ); ;

            # endregion ADD DB Context

            #region ADD Identity 
            services
                .AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<MedicDbContext>()
                .AddDefaultTokenProviders();

            #endregion ADD Identity 

            #region ADD Authentication Schema 
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(
                options =>
                {
                    options.LoginPath = "/Accessapi/Login";
                    options.LogoutPath = "/Accessapi/Logout";
                    options.AccessDeniedPath = "/Accessapi/Login";
                }
                );

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.SameSite = SameSiteMode.None;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/accessapi/login";
                options.LogoutPath = "/accessapi/logout";
                options.AccessDeniedPath = "/accessapi/login";
                options.SlidingExpiration = true;
            });

            services.AddAuthorization(

                );
            #endregion ADD Authentication Schema 

            


            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors("AllowFrontend");
            app.UseSession();
            app.UseAuthentication();

            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
