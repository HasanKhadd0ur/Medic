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

            services.AddScoped<DbContext, MedicDbContext>();
            services.AddScoped<Mapper>();
            
            services.AddAutoMapper(typeof(ApplicationCore.Mapper.ObjectMapper));
            #region ADD Scoped Repository 
            services.AddScoped(typeof(IUnitOfWork<>),typeof(UnitOfWork<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
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
                    options.LoginPath = "/Access/Login";
                    options.LogoutPath = "/Access/Logout";
                    options.AccessDeniedPath = "/Access/Login";
                }
                );
            services.AddAuthorization(
                
                );
            #endregion ADD Authentication Schema 
           
            services.AddSession();

            services.AddControllersWithViews();
            
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

            app.UseAuthentication();
           
            app.UseAuthorization();

            app.UseSession();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                 });
        }
    }
}
