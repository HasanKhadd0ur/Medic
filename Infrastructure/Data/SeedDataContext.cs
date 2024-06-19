using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SeedDataContext
    {
        public static ModelBuilder Seed(ModelBuilder modelBuilder)
        {
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
                .HasData(new IdentityUserRole<String>
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
            var ph = new PasswordHasher<IdentityUser>();

            var admin = new User
            {
                Id = "1",
                FirstName = "Hasan",
                LastName = "Kh",
                Avatar = "avatar.jpg",
                Email = "hasan@b",
                UserName = "Hasan.Bahjat",
                PasswordHash = ph.HashPassword(null, "123@Aa"),
                NormalizedEmail = "hasan@b",
                NormalizedUserName = "Hasan.Bahjat",

                CreationTime = DateTime.Now
            };
            var PatientAccount = new User
            {
                Id = "2",
                FirstName = "Hasan",
                LastName = "Khaddour",
                Avatar = "avatar1.jpg",
                Email = "hasan.bahjat@mail.y",
                PasswordHash = ph.HashPassword(null, "123@Aa"),
                UserName = "Hasan.Khaddour",
                NormalizedEmail = "hasan@b",
                NormalizedUserName = "Hasan.khaddour",
                CreationTime = DateTime.Now
            };


            modelBuilder.Entity<User>()
                .HasData(
                admin,
                PatientAccount
                );

            #endregion User
            #region Patients 
            var Patient = new Patient
            {
                Id = 1,

                BIO = "a Patient ",
                UserId = PatientAccount.Id,

            };
            modelBuilder.Entity<Patient>().HasData(
                Patient
                );

            #endregion Patients
            #region Categories
            var c1 = new Category { Id = 1, Name = "Antibiotic" };

            var c2 = new Category { Id = 2, Name = "Painkiller" };


            modelBuilder.Entity<Category>().HasData(
                c1, c2
                );
            #endregion Categories
            #region MedicineType
            modelBuilder.Entity<MedicineType>().HasData(
                new MedicineType { Id = 1, TypeName = "Tablet" },
                new MedicineType { Id = 2, TypeName = "Syrup" }
            );
            #endregion MedicineType
            #region Ingredients
            modelBuilder.Entity<Ingredient>().HasData(
                  new Ingredient { Id = 1, Name = "Amoxicillin" },
                  new Ingredient { Id = 2, Name = "Paracetamol" }
            );
            #endregion Ingredients
            #region Medicines 
            var med = new Medicine
            {
                Id = 1,
                ScintificName = "Augmentine",
                TradeName = "Augmentine",
                Description = "antibitic mdicine",
                ManufactureName = "Ibin Sina",
                SideEffect = "No. ",
                //Category=c1 ,
                Image = "med1.png",
                Dosage = 12,
                Price = 2500,

            };

            //   modelBuilder.Entity<MedicineIngredient>().HasData(
            //     new MedicineIngredient { Id = 1, MedicineId = 1, IngredientId = 1 },
            //     new MedicineIngredient { Id = 2, MedicineId = 2, IngredientId = 2 }
            //);
            modelBuilder.Entity<Medicine>().HasData(med);

            #endregion Medicines
            #region MedicalState
            var st = new MedicalState
            {
                Id = 1,
                PatientId = 1,
                PrescriptionTime = DateTime.Now,

            };
            modelBuilder.Entity<MedicalState>().HasData(st);
            #endregion MedicalState

            return modelBuilder;
        }

    }
}
