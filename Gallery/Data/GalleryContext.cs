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

        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoCategory> PhotoCategories { get; set; }

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

            // Add Category
            builder.Entity<Category>().Property(p => p.Name).HasMaxLength(30).IsRequired();
            builder.Entity<Category>().HasIndex(p => p.Name).IsUnique();

            // Add Default Categories
            builder.Entity<Category>().HasData(new Category { Id = 1, Name = "General" });
            builder.Entity<Category>().HasData(new Category { Id = 2, Name = "Architecture" });
            builder.Entity<Category>().HasData(new Category { Id = 3, Name = "Technology" });
            builder.Entity<Category>().HasData(new Category { Id = 4, Name = "Animals" });

            // Add Photo Schema
            builder.Entity<Photo>().Ignore(p => p.Categories);
            builder.Entity<Photo>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Entity<Photo>().Property(p => p.FileName).HasMaxLength(100).IsRequired();
            builder.Entity<Photo>().Property(p => p.Url).HasMaxLength(200).IsRequired();
            builder.Entity<Photo>().Property(p => p.Description).HasMaxLength(500);
            builder.Entity<Photo>().Property(p => p.Company).HasMaxLength(100);
            builder.Entity<Photo>().Property(p => p.Owner).HasMaxLength(50);
            builder.Entity<Photo>().Property(p => p.ActionUrl).HasMaxLength(200);
            builder.Entity<Photo>().HasIndex(p => p.Name).IsUnique();

            builder.Entity<PhotoCategory>().HasKey(p => new { p.PhotoId, p.CategoryId });
            builder.Entity<PhotoCategory>().HasOne(p => p.Photo)
                .WithMany(p => p.PhotoCategories)
                .HasForeignKey(p => p.PhotoId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<PhotoCategory>().HasOne(p => p.Category)
                .WithMany(p => p.PhotoCategories)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Add Default Photos
            var building = new Photo
            {
                Id = 1,
                Name = "Building",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "Picture for a building",
                Url = "img/building.jpg",
                ActionUrl = "https://google.com",
                FileName = "building.jpg",
                Length = 47785
            };

            var colorfull = new Photo
            {
                Id = 2,
                Name = "Colorfull",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "Some colorfull picture",
                Url = "img/colorfull.jpg",
                ActionUrl = "https://google.com",
                FileName = "colorfull.jpg",
                Length = 74193
            };

            var deer = new Photo
            {
                Id = 3,
                Name = "Deer",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A deer",
                Url = "img/deer.jpg",
                ActionUrl = "https://google.com",
                FileName = "deer.jpg",
                Length = 85870
            };

            var desk = new Photo
            {
                Id = 4,
                Name = "Desk",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A picture of a desk",
                Url = "img/desk.jpg",
                ActionUrl = "https://google.com",
                FileName = "desk.jpg",
                Length = 19666
            };

            var bus = new Photo
            {
                Id = 5,
                Name = "Bus",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A picture of a bus",
                Url = "img/bus.jpg",
                ActionUrl = "https://google.com",
                FileName = "bus.jpg",
                Length = 78440
            };

            var drop = new Photo
            {
                Id = 6,
                Name = "Bread",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A picture of bread",
                Url = "img/drop.jpg",
                ActionUrl = "https://google.com",
                FileName = "drop.jpg",
                Length = 53918
            };

            var lava = new Photo
            {
                Id = 7,
                Name = "Lava",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A picture of lava",
                Url = "img/lava.jpg",
                ActionUrl = "https://google.com",
                FileName = "lava.jpg",
                Length = 55451
            };

            var loft = new Photo
            {
                Id = 8,
                Name = "Loft",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A picture of stairs",
                Url = "img/loft.jpg",
                ActionUrl = "https://google.com",
                FileName = "loft.jpg",
                Length = 43047
            };

            var race = new Photo
            {
                Id = 9,
                Name = "Race",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A picture of a race",
                Url = "img/race.jpg",
                ActionUrl = "https://google.com",
                FileName = "race.jpg",
                Length = 91694
            };

            var ryno = new Photo
            {
                Id = 10,
                Name = "Ryno",
                Company = "YamanCo",
                Owner = "Yaman",
                Description = "A picture of a ryno",
                Url = "img/ryno.jpg",
                ActionUrl = "https://google.com",
                FileName = "ryno.jpg",
                Length = 66237
            };

            builder.Entity<Photo>().HasData(building);
            builder.Entity<Photo>().HasData(colorfull);
            builder.Entity<Photo>().HasData(deer);
            builder.Entity<Photo>().HasData(desk);
            builder.Entity<Photo>().HasData(bus);
            builder.Entity<Photo>().HasData(drop);
            builder.Entity<Photo>().HasData(lava);
            builder.Entity<Photo>().HasData(loft);
            builder.Entity<Photo>().HasData(race);
            builder.Entity<Photo>().HasData(ryno);

            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = building.Id, CategoryId = 2 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = colorfull.Id, CategoryId = 1 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = deer.Id, CategoryId = 4 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = desk.Id, CategoryId = 3 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = bus.Id, CategoryId = 1 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = drop.Id, CategoryId = 1 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = lava.Id, CategoryId = 1 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = loft.Id, CategoryId = 1 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = loft.Id, CategoryId = 2 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = race.Id, CategoryId = 1 });
            builder.Entity<PhotoCategory>().HasData(new PhotoCategory { PhotoId = ryno.Id, CategoryId = 4 });

        }
    }
}
