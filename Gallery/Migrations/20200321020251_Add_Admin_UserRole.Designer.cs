﻿// <auto-generated />
using System;
using Gallery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gallery.Migrations
{
    [DbContext(typeof(GalleryContext))]
    [Migration("20200321020251_Add_Admin_UserRole")]
    partial class Add_Admin_UserRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gallery.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "56c2626b-4440-4bf9-8ac0-36e9c22336b5",
                            Email = "admin@gallery",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GALLERY",
                            NormalizedUserName = "ADMIN@GALLERY",
                            PasswordHash = "AQAAAAEAACcQAAAAEIGk9cFSQKSK6tqouTnvIrgybsxiLuCBUCeNEcjA5/DmlB9Cg/Vq2s1TWpGsp0iLcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8fcf78e1-7989-42cf-bb9e-948fdb8464c9",
                            TwoFactorEnabled = false,
                            UserName = "admin@gallery"
                        });
                });

            modelBuilder.Entity("Gallery.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "General"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Architecture"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Technology"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Animals"
                        });
                });

            modelBuilder.Entity("Gallery.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<long>("Length")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "Picture for a building",
                            FileName = "building.jpg",
                            Length = 47785L,
                            Name = "Building",
                            Owner = "Yaman",
                            Url = "img/building.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "Some colorfull picture",
                            FileName = "colorfull.jpg",
                            Length = 74193L,
                            Name = "Colorfull",
                            Owner = "Yaman",
                            Url = "img/colorfull.jpg"
                        },
                        new
                        {
                            Id = 3,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A deer",
                            FileName = "deer.jpg",
                            Length = 85870L,
                            Name = "Deer",
                            Owner = "Yaman",
                            Url = "img/deer.jpg"
                        },
                        new
                        {
                            Id = 4,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A picture of a desk",
                            FileName = "desk.jpg",
                            Length = 19666L,
                            Name = "Desk",
                            Owner = "Yaman",
                            Url = "img/desk.jpg"
                        },
                        new
                        {
                            Id = 5,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A picture of a bus",
                            FileName = "bus.jpg",
                            Length = 78440L,
                            Name = "Bus",
                            Owner = "Yaman",
                            Url = "img/bus.jpg"
                        },
                        new
                        {
                            Id = 6,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A picture of bread",
                            FileName = "drop.jpg",
                            Length = 53918L,
                            Name = "Bread",
                            Owner = "Yaman",
                            Url = "img/drop.jpg"
                        },
                        new
                        {
                            Id = 7,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A picture of lava",
                            FileName = "lava.jpg",
                            Length = 55451L,
                            Name = "Lava",
                            Owner = "Yaman",
                            Url = "img/lava.jpg"
                        },
                        new
                        {
                            Id = 8,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A picture of stairs",
                            FileName = "loft.jpg",
                            Length = 43047L,
                            Name = "Loft",
                            Owner = "Yaman",
                            Url = "img/loft.jpg"
                        },
                        new
                        {
                            Id = 9,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A picture of a race",
                            FileName = "race.jpg",
                            Length = 91694L,
                            Name = "Race",
                            Owner = "Yaman",
                            Url = "img/race.jpg"
                        },
                        new
                        {
                            Id = 10,
                            ActionUrl = "https://google.com",
                            Company = "YamanCo",
                            Description = "A picture of a ryno",
                            FileName = "ryno.jpg",
                            Length = 66237L,
                            Name = "Ryno",
                            Owner = "Yaman",
                            Url = "img/ryno.jpg"
                        });
                });

            modelBuilder.Entity("Gallery.Models.PhotoCategory", b =>
                {
                    b.Property<int>("PhotoId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("PhotoId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("PhotoCategories");

                    b.HasData(
                        new
                        {
                            PhotoId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            PhotoId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            PhotoId = 3,
                            CategoryId = 4
                        },
                        new
                        {
                            PhotoId = 4,
                            CategoryId = 3
                        },
                        new
                        {
                            PhotoId = 5,
                            CategoryId = 1
                        },
                        new
                        {
                            PhotoId = 6,
                            CategoryId = 1
                        },
                        new
                        {
                            PhotoId = 7,
                            CategoryId = 1
                        },
                        new
                        {
                            PhotoId = 8,
                            CategoryId = 1
                        },
                        new
                        {
                            PhotoId = 8,
                            CategoryId = 2
                        },
                        new
                        {
                            PhotoId = 9,
                            CategoryId = 1
                        },
                        new
                        {
                            PhotoId = 10,
                            CategoryId = 4
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "fb5b2cda-e5a4-4b27-b58b-cbefe1206dff",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "60ecd4a2-ef30-46dd-818e-5a0155b08cea",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Gallery.Models.PhotoCategory", b =>
                {
                    b.HasOne("Gallery.Models.Category", "Category")
                        .WithMany("PhotoCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gallery.Models.Photo", "Photo")
                        .WithMany("PhotoCategories")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Gallery.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Gallery.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gallery.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Gallery.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
