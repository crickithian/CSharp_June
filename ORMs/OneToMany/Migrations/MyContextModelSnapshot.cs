﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneToMany.Models;

namespace OneToMany.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OneToMany.Models.Killer", b =>
                {
                    b.Property<int>("KillerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PreferredWeapon")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("KillerId");

                    b.ToTable("Killers");
                });

            modelBuilder.Entity("OneToMany.Models.Victim", b =>
                {
                    b.Property<int>("VictimId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CauseOfDeath")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateOfDeath");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("KillerId");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("VictimId");

                    b.HasIndex("KillerId");

                    b.ToTable("Victims");
                });

            modelBuilder.Entity("OneToMany.Models.Victim", b =>
                {
                    b.HasOne("OneToMany.Models.Killer", "Murderer")
                        .WithMany("AllVictims")
                        .HasForeignKey("KillerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}