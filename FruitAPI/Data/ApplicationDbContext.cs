using FruitAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace FruitAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string adminRoleId = "1";
            string backOfficeRoleId = "2";
            string frontOfficeRoleId = "3";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = backOfficeRoleId, Name = "BackOffice", NormalizedName = "BACKOFFICE" },
                new IdentityRole { Id = frontOfficeRoleId, Name = "FrontOffice", NormalizedName = "FRONTOFFICE" }
            );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "1",
                    UserName = "AdminUser",
                    NormalizedUserName = "ADMINUSER",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin123.")
                },
                new ApplicationUser
                {
                    Id = "2",
                    UserName = "BackOfficeUser",
                    NormalizedUserName = "BACKOFFICEUSER",
                    Email = "backoffice@example.com",
                    NormalizedEmail = "BACKOFFICE@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "User123.")
                },
                new ApplicationUser
                {
                    Id = "3",
                    UserName = "FrontOfficeUser",
                    NormalizedUserName = "FRONTOFFICEUSER",
                    Email = "frontoffice@example.com",
                    NormalizedEmail = "FRONTOFFICE@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "User123.")
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = adminRoleId },
                new IdentityUserRole<string> { UserId = "2", RoleId = backOfficeRoleId },
                new IdentityUserRole<string> { UserId = "3", RoleId = frontOfficeRoleId }
            );
        }

        public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlite("Data Source=app.db"); // Replace with your connection string

                return new ApplicationDbContext(optionsBuilder.Options);
            }
        }

    }
}
