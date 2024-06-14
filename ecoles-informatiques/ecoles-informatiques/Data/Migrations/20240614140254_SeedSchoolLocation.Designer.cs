﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using ecoles_informatiques.Data;

#nullable disable

namespace ecoles_informatiques.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240614140254_SeedSchoolLocation")]
    partial class SeedSchoolLocation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "60fb5145-7fa7-4e07-af4d-323a8cb19b39",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f566d4f1-71db-4e1d-9d2f-0687c115a3bd",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPk+QzkkQL9UCTnt7ytQhAwrqcZtuXn//4ew15/RNW1GhploP4Q27tA/K1W6UlPjoA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "OECJYRXF22Y64JSHS5RWDF2M7GYBQE6G",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "6250adfa-eb23-455b-aea7-494361b7f13f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "be3506fd-2240-41aa-83fa-5ff71692e6e7",
                            Email = "test@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@TEST.COM",
                            NormalizedUserName = "TEST@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEXOY9AhrU7GlpjYz2sEqlCIKzTATb6ljJRGtM/ZPAuzZScicbu6WbyyuNUl7gyCPQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "RVWKTAEQWZLJUJXFHCXUHCQIDDWW27FQ",
                            TwoFactorEnabled = false,
                            UserName = "test@test.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "60fb5145-7fa7-4e07-af4d-323a8cb19b39",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "6250adfa-eb23-455b-aea7-494361b7f13f",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ecoles_informatiques.Models.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GradeLevelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradeLevelId");

                    b.ToTable("Diplomas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GradeLevelId = 4,
                            Name = "Diplôme d'ingénieur"
                        },
                        new
                        {
                            Id = 2,
                            GradeLevelId = 4,
                            Name = "Master"
                        },
                        new
                        {
                            Id = 3,
                            GradeLevelId = 3,
                            Name = "Licence"
                        },
                        new
                        {
                            Id = 4,
                            GradeLevelId = 2,
                            Name = "BTS"
                        },
                        new
                        {
                            Id = 5,
                            GradeLevelId = 2,
                            Name = "IUT"
                        });
                });

            modelBuilder.Entity("ecoles_informatiques.Models.Formation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ApprenticeshipStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiplomaId")
                        .HasColumnType("int");

                    b.Property<int>("GradeLevelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StudentStatus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaId");

                    b.HasIndex("GradeLevelId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Formations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApprenticeshipStatus = true,
                            Description = "Formation en cybersécurité avec spécialisation en systèmes embarqués.",
                            DiplomaId = 1,
                            GradeLevelId = 4,
                            Name = "Ingénierie en Cybersécurité",
                            Price = 5000.0,
                            SchoolId = 1,
                            Slug = "ingenierie-cybersecurite",
                            StudentStatus = true
                        },
                        new
                        {
                            Id = 2,
                            ApprenticeshipStatus = false,
                            Description = "Programme de Bachelor avec des spécialisations en développement logiciel et data science.",
                            DiplomaId = 3,
                            GradeLevelId = 3,
                            Name = "Bachelor en Informatique",
                            Price = 3500.0,
                            SchoolId = 2,
                            Slug = "bachelor-informatique",
                            StudentStatus = true
                        },
                        new
                        {
                            Id = 3,
                            ApprenticeshipStatus = true,
                            Description = "Diplôme Universitaire de Technologie en informatique avec une option en réseaux et télécommunications.",
                            DiplomaId = 5,
                            GradeLevelId = 2,
                            Name = "DUT Informatique",
                            Price = 0.0,
                            SchoolId = 3,
                            Slug = "dut-informatique",
                            StudentStatus = true
                        },
                        new
                        {
                            Id = 4,
                            ApprenticeshipStatus = true,
                            Description = "Brevet de Technicien Supérieur en services informatiques aux organisations.",
                            DiplomaId = 4,
                            GradeLevelId = 2,
                            Name = "BTS Services Informatiques aux Organisations",
                            Price = 0.0,
                            SchoolId = 4,
                            Slug = "bts-sio",
                            StudentStatus = true
                        },
                        new
                        {
                            Id = 5,
                            ApprenticeshipStatus = true,
                            Description = "Licence professionnelle avec des cours avancés en gestion des systèmes d'information.",
                            DiplomaId = 3,
                            GradeLevelId = 3,
                            Name = "Licence Professionnelle en Informatique",
                            Price = 0.0,
                            SchoolId = 5,
                            Slug = "licence-pro-informatique",
                            StudentStatus = true
                        },
                        new
                        {
                            Id = 6,
                            ApprenticeshipStatus = true,
                            Description = "Formation pour devenir développeur web et web mobile, incluant des compétences en front-end et back-end.",
                            DiplomaId = 4,
                            GradeLevelId = 2,
                            Name = "Développeur Web et Web Mobile",
                            Price = 5200.0,
                            SchoolId = 6,
                            Slug = "dev-web-mobile",
                            StudentStatus = true
                        },
                        new
                        {
                            Id = 7,
                            ApprenticeshipStatus = true,
                            Description = "Formation de manager en cybersécurité pour acquérir des compétences avancées en protection des systèmes d'information.",
                            DiplomaId = 2,
                            GradeLevelId = 4,
                            Name = "Manager Cybersécurité",
                            Price = 7500.0,
                            SchoolId = 6,
                            Slug = "manager-cybersecurite",
                            StudentStatus = true
                        });
                });

            modelBuilder.Entity("ecoles_informatiques.Models.GradeLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LongLabel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortLabel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GradeLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LongLabel = "Baccalauréat",
                            ShortLabel = "Bac"
                        },
                        new
                        {
                            Id = 2,
                            LongLabel = "Diplôme de niveau Bac+2",
                            ShortLabel = "Bac+2"
                        },
                        new
                        {
                            Id = 3,
                            LongLabel = "Diplôme de niveau Bac+3",
                            ShortLabel = "Bac+3"
                        },
                        new
                        {
                            Id = 4,
                            LongLabel = "Diplôme de niveau Bac+5",
                            ShortLabel = "Bac+5"
                        });
                });

            modelBuilder.Entity("ecoles_informatiques.Models.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("ecoles_informatiques.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "38 Rue des Drs Calmette et Guérin",
                            City = "Laval",
                            Description = "École d'ingénieurs spécialisée en numérique et cybersécurité",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.769905 48.070711)"),
                            Name = "ESIEA Laval",
                            Slug = "esiea-laval"
                        },
                        new
                        {
                            Id = 2,
                            Address = "123 Rue de Bretagne",
                            City = "Laval",
                            Description = "École de commerce offrant des BTS et des Bachelors",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.780618 48.070058)"),
                            Name = "ESUP Laval",
                            Slug = "esup-laval"
                        },
                        new
                        {
                            Id = 3,
                            Address = "52 Rue des Docteurs Calmette",
                            City = "Laval",
                            Description = "Institut Universitaire de Technologie",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.770441 48.071255)"),
                            Name = "IUT Laval",
                            Slug = "iut-laval"
                        },
                        new
                        {
                            Id = 4,
                            Address = "14 Rue de l'Alma",
                            City = "Laval",
                            Description = "Lycée général et technologique",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.769948 48.068339)"),
                            Name = "Lycée Douanier Rousseau",
                            Slug = "lycee-douanier-rousseau"
                        },
                        new
                        {
                            Id = 5,
                            Address = "28 Rue des Déportés",
                            City = "Laval",
                            Description = "Lycée proposant des formations professionnelles et technologiques",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.770282 48.069778)"),
                            Name = "Lycée Réaumur",
                            Slug = "lycee-reaumur"
                        },
                        new
                        {
                            Id = 6,
                            Address = "5 Boulevard de l'Industrie, Saint-Berthevin",
                            City = "Laval",
                            Description = "Institut d'Informatique Appliquée spécialisé en informatique et numérique",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.800985 48.061545)"),
                            Name = "IIA Laval",
                            Slug = "iia-laval"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ecoles_informatiques.Models.Diploma", b =>
                {
                    b.HasOne("ecoles_informatiques.Models.GradeLevel", "Gradelevels")
                        .WithMany()
                        .HasForeignKey("GradeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gradelevels");
                });

            modelBuilder.Entity("ecoles_informatiques.Models.Formation", b =>
                {
                    b.HasOne("ecoles_informatiques.Models.Diploma", "Diploma")
                        .WithMany("Formations")
                        .HasForeignKey("DiplomaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ecoles_informatiques.Models.GradeLevel", "MinimumGrade")
                        .WithMany()
                        .HasForeignKey("GradeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ecoles_informatiques.Models.School", "School")
                        .WithMany("Formations")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diploma");

                    b.Navigation("MinimumGrade");

                    b.Navigation("School");
                });

            modelBuilder.Entity("ecoles_informatiques.Models.Diploma", b =>
                {
                    b.Navigation("Formations");
                });

            modelBuilder.Entity("ecoles_informatiques.Models.School", b =>
                {
                    b.Navigation("Formations");
                });
#pragma warning restore 612, 618
        }
    }
}
