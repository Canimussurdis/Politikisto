﻿// <auto-generated />
using System;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppAmalt.Migrations
{
    [DbContext(typeof(DatabaseContexts))]
    [Migration("20220416161438_Age")]
    partial class Age
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Age", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Between20_30Age")
                        .HasColumnType("integer");

                    b.Property<int>("Between30_40Age")
                        .HasColumnType("integer");

                    b.Property<int>("Between40_60Age")
                        .HasColumnType("integer");

                    b.Property<int>("Less20Age")
                        .HasColumnType("integer");

                    b.Property<int>("Over60")
                        .HasColumnType("integer");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Age");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MenFollower")
                        .HasColumnType("integer");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<int>("WomenFollower")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.LifeMain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CareerMoney")
                        .HasColumnType("integer");

                    b.Property<int>("Entertainment")
                        .HasColumnType("integer");

                    b.Property<int>("FamePower")
                        .HasColumnType("integer");

                    b.Property<int>("Family")
                        .HasColumnType("integer");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<int>("Science")
                        .HasColumnType("integer");

                    b.Property<int>("SelfDevelopment")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("LifeMains");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Party", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Fractions");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Political", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Communists")
                        .HasColumnType("integer");

                    b.Property<int>("Conservatives")
                        .HasColumnType("integer");

                    b.Property<int>("Indifferents")
                        .HasColumnType("integer");

                    b.Property<int>("Liberals")
                        .HasColumnType("integer");

                    b.Property<int>("Moderate")
                        .HasColumnType("integer");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<int>("Socialists")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Politicals");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Portrait", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("LifeMain")
                        .HasColumnType("text");

                    b.Property<string>("Occupation")
                        .HasColumnType("text");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<string>("Political")
                        .HasColumnType("text");

                    b.Property<string>("Relation")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Portraits");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.ValueCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CityId")
                        .IsUnique();

                    b.HasIndex("PartyId");

                    b.ToTable("ValueCitis");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Age", b =>
                {
                    b.HasOne("AppAmalt.ModelsDatabase.Party", "Party")
                        .WithOne("Age")
                        .HasForeignKey("AppAmalt.ModelsDatabase.Age", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Gender", b =>
                {
                    b.HasOne("AppAmalt.ModelsDatabase.Party", "Party")
                        .WithOne("Gender")
                        .HasForeignKey("AppAmalt.ModelsDatabase.Gender", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.LifeMain", b =>
                {
                    b.HasOne("AppAmalt.ModelsDatabase.Party", "Party")
                        .WithOne("LifeMain")
                        .HasForeignKey("AppAmalt.ModelsDatabase.LifeMain", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Party", b =>
                {
                    b.HasOne("AppAmalt.ModelsDatabase.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Political", b =>
                {
                    b.HasOne("AppAmalt.ModelsDatabase.Party", "Party")
                        .WithOne("Political")
                        .HasForeignKey("AppAmalt.ModelsDatabase.Political", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.Portrait", b =>
                {
                    b.HasOne("AppAmalt.ModelsDatabase.Party", "Party")
                        .WithOne("Portrait")
                        .HasForeignKey("AppAmalt.ModelsDatabase.Portrait", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.ModelsDatabase.ValueCity", b =>
                {
                    b.HasOne("AppAmalt.ModelsDatabase.City", "City")
                        .WithOne("ValueCity")
                        .HasForeignKey("AppAmalt.ModelsDatabase.ValueCity", "CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppAmalt.ModelsDatabase.Party", "Party")
                        .WithMany()
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}