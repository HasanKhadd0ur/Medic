using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using ApplicationCore.Services;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Repositories;
using ApplicationCore.DTOs;
using ApplicationCore.Mapper;
using System;
using Microsoft.AspNetCore.Http;
using ApplicationCore.Mappere;
using WebPresentation.Filters.ModelStateValidation;
using WebPresentation.Services;
using ApplicationCore.Interfaces.IAuthentication;
using ApplicationCore.Authentication;

namespace WebPresentation
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
            #region ADD DB Context
            services.AddScoped<DbContext, MedicDbContext>();
            services.AddDbContext<MedicDbContext>(
                options => {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                });

            # endregion ADD DB Context            

            #region Mapper Config
            services.AddScoped<Mapper>();
            services.AddAutoMapper(typeof(ObjectMapper), typeof(ViewModelObjectMapper));

            #endregion Mpper Config
            
            #region Cors
            services.AddCors(options =>
            {
            
                options.AddPolicy("AllowFrontend",
                    builder => builder
                        .WithOrigins("http://localhost:3000") // Add your frontend URL here
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials());

            });
            #endregion Cors

            #region ADD Scopped Repository 
            
            services.AddScoped(typeof(IUnitOfWork<>),typeof(UnitOfWork<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IMedicalStateRepository,MedicalStateRepository>();
            services.AddScoped<IMedicineRepository, MedicineRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();

            #endregion ADD Scopped Repository

            #region ADD Scopped  Services
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IMedicalStateService, MedicalStateService>();
            services.AddScoped<IMedicineService, MedicineService>();
            services.AddScoped<IIngredientService, IngredientService>();
            #endregion ADD Scopped  Services
            
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
                    options.LoginPath = "/Access/Login";
                    options.LogoutPath = "/Access/Logout";
                    options.AccessDeniedPath = "/Access/Login";
                }
                );
            
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.SameSite = SameSiteMode.None;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/access/login"; 
                options.LogoutPath = "/access/logout"; 
                options.AccessDeniedPath = "/access/login";
                options.SlidingExpiration = true;
            });
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });
            services.AddAuthorization(
                
                );
            #endregion ADD Authentication Schema 

            #region ADD Session
            services.AddSession();
            #endregion ADD Session

            #region register image service 
            services.AddScoped<IImageService,ImageService>();
            #endregion register image service 

            #region ADD atuhentication manager 
            services.AddScoped<IAuthenticationManager,AuthenticationManager>();
            #endregion ADD atuhentication manager 

            services.AddScoped<StateValidationFilter>();
            

            services.AddControllersWithViews()
                .AddNewtonsoftJson(
                options =>
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
          //  app.UseStatusCodePagesWithRedirects();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors("AllowFrontend");

            app.UseAuthentication();
           
            app.UseAuthorization();

            app.UseSession();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "notFound",
                    pattern: "{*url}",
                    defaults: new { controller = "Home", action = "NotFoundPage" });
             });
        }
    }
}
