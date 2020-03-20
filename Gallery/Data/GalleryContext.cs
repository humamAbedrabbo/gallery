using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gallery.Data
{
    public class GalleryContext : IdentityDbContext<AppUser>
    {
        public GalleryContext(DbContextOptions<GalleryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Add Identity Schema
            builder.Entity<AppUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString("d") });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER", ConcurrencyStamp = Guid.NewGuid().ToString("d") });

            // Add_Admin
            var hasher = new PasswordHasher<AppUser>();
            var admin = new AppUser
            {
                Id = "1",
                UserName = "admin@gallery",
                NormalizedUserName = "ADMIN@GALLERY",
                Email = "admin@gallery",
                NormalizedEmail = "ADMIN@GALLERY",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Welcome@123");
            builder.Entity<AppUser>().HasData(admin);

        }
    }
}
