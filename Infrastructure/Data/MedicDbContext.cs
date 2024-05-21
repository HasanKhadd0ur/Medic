using ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MedicDbContext : IdentityDbContext<User>
    {
        public MedicDbContext(DbContextOptions<MedicDbContext> options)
           : base(options)
        {
         
        }
        
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MedicineType> MedicineTypes { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TI6EF1L\\SQLEXPRESS;Initial Catalog=portfoilo;Integrated Security=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");


            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.Ingredients)
                .WithMany(e => e.Medicines)
                .UsingEntity<MedicineIngredient>(
                    l => l.HasOne<Ingredient>(e => e.Ingredient)
                        .WithMany(e => e.MedicineIngredients)
                        .HasForeignKey(e => e.IngredientId),
                    r => r.HasOne<Medicine>(e => e.Medicine)
                        .WithMany(e => e.MedicineIngredients)
                        .HasForeignKey(e => e.MedicineId)
             );

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Medicines)
                .WithMany(e => e.Patients)
                .UsingEntity<PatientMedicine>(
                    l => l.HasOne<Medicine>(e => e.Medicine)
                        .WithMany(e => e.PatientMedicines)
                        .HasForeignKey(e => e.MedicineId),
                    r => r.HasOne<Patient>(e => e.Patient)
                        .WithMany(e => e.PatientMedicines)
                        .HasForeignKey(e => e.PatientId)
             );

            modelBuilder.Entity<Patient>()
                .HasOne(o => o.User);

            modelBuilder.Entity<Medicine>()
                .HasOne(o => o.Category)
                ;
            modelBuilder.Entity<Medicine>()
                .HasOne(o => o.MedicineType);
            modelBuilder.Entity<User>().Property(e => e.Id).HasMaxLength(200);
            modelBuilder.Entity<IdentityRole>().Property(e => e.Id).HasMaxLength(200);
         
            // Seed(modelBuilder);

           base.OnModelCreating(modelBuilder);



        }
        public void Seed(ModelBuilder modelBuilder) {
            var P = new Patient
            {
                Id = 1,
                FirstName = "Hasasn",
                LastName = "Khaddour",
                Avatar = "avatr.png"

            };
            modelBuilder.Entity<Patient>().HasData(P);

            var appUser = new User
            {
                Id = "123-1213",
                Email = "hasan@b",
                EmailConfirmed = true,
                UserName = "frankofoedu@gmail.com",
                NormalizedUserName = "FRANKOFOEDU@GMAIL.COM",
                PatientId = 1

            };
            //set user password
            //appUser.Patient = P;
            PasswordHasher<User> ph = new PasswordHasher<User>();
            appUser.PasswordHash = ph.HashPassword(appUser, "123@Aa");

            //seed user
            modelBuilder.Entity<User>().HasData(appUser);


        }
    }
    }
