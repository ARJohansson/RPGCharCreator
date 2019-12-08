﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPGCharacterCreator.Repos;

namespace RPGCharacterCreator.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RPGCharacterCreator.Models.Ability", b =>
                {
                    b.Property<int>("AbilityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ability1");

                    b.Property<string>("Ability2");

                    b.Property<string>("Ability3");

                    b.Property<string>("Ability4");

                    b.Property<string>("Ability5");

                    b.Property<int?>("CharacterID");

                    b.HasKey("AbilityID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("RPGCharacterCreator.Models.Character", b =>
                {
                    b.Property<int>("CharacterID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsMonster");

                    b.Property<bool>("IsNPC");

                    b.Property<bool>("IsPlayer");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.Property<int?>("UserID");

                    b.HasKey("CharacterID");

                    b.HasIndex("UserID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("RPGCharacterCreator.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RPGCharacterCreator.Models.Ability", b =>
                {
                    b.HasOne("RPGCharacterCreator.Models.Character")
                        .WithMany("Abilities")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("RPGCharacterCreator.Models.Character", b =>
                {
                    b.HasOne("RPGCharacterCreator.Models.User")
                        .WithMany("Characters")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
