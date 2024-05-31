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
           base.OnModelCreating(modelBuilder);

            Seed(modelBuilder);

        }
        public void Seed(ModelBuilder modelBuilder) {
            #region Roles 
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Id = "1-2-1"
                },
                new IdentityRole
                {
                    Name = "patient",
                    NormalizedName = "patient",
                    Id = "1"
                }

                );


            modelBuilder.Entity<IdentityUserRole<String>>()
                .HasData( new IdentityUserRole<String>
                 {
                     UserId = "1",
                     RoleId = "1-2-1"
                 }, new IdentityUserRole<String>
                 {
                     UserId = "2",
                     RoleId = "1"

                 }

                );
            #endregion Roles
            #region User 
            PasswordHasher<User> ph = new PasswordHasher<User>();

            var admin = new User
            {
                Id = "1",
                FirstName = "Hasan",
                LastName = "Kh",
                Avatar = "avatar.jpg",
                Email = "hasan@b",
                UserName="Hasan.Bahjat",
                NormalizedEmail="hasan@b",
                NormalizedUserName= "Hasan.Bahjat",
              
                CreationTime = DateTime.Now
            };
            var PatientAccount = new User
            {
                Id = "2",
                FirstName = "Hasan",
                LastName = "Khaddour",
                Avatar = "avatar1.jpg",
                Email = "hasan.bahjat@mail.y",

                UserName = "Hasan.Khaddour",
                NormalizedEmail = "hasan@b",
                NormalizedUserName = "Hasan.khaddour",
                CreationTime = DateTime.Now
            };

            admin.PasswordHash = ph.HashPassword(admin, "123@Aa");
            PatientAccount.PasswordHash = ph.HashPassword(PatientAccount, "123@Aa");

            modelBuilder.Entity<User>()
                .HasData(
                admin,
                PatientAccount
                );

            #endregion User
            #region Patients 
            var Patient = new Patient {
                Id=1,
                
                BIO = "a Patient ",
                UserId = PatientAccount.Id,
                
            };
            modelBuilder.Entity<Patient>().HasData(
                Patient
                );

            #endregion Patients
            #region Medicines 
            var med = new Medicine
            {
                Id=-1,
                Name = "Augmentine",
                Image="med1.png",
                Dosage = 12,
                Price = 2500,
                
                

            };
            var c = new Category { Id = 1, Name = "Augmentine" };
            modelBuilder.Entity<Category>().HasData(c);
       //     med.Category = c;
            modelBuilder.Entity<Medicine>().HasData(med);

            #endregion Medicines
        }
    }
    }
