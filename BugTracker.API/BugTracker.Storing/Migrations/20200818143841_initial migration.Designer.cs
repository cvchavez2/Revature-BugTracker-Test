﻿// <auto-generated />
using System;
using BugTracker.Storing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.Storing.Migrations
{
    [DbContext(typeof(BugTrackerDbContext))]
    [Migration("20200818143841_initial migration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("BugTracker.Domain.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Commenter")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TicketId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<int>("DevAssignedId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjReferenceId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Submitter")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Comment", b =>
                {
                    b.HasOne("BugTracker.Domain.Models.Ticket", null)
                        .WithMany("Comments")
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Developer", b =>
                {
                    b.HasOne("BugTracker.Domain.Models.Project", null)
                        .WithMany("Developers")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Manager", b =>
                {
                    b.HasOne("BugTracker.Domain.Models.Project", null)
                        .WithMany("Managers")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("BugTracker.Domain.Models.Ticket", b =>
                {
                    b.HasOne("BugTracker.Domain.Models.Project", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}