﻿// <auto-generated />
using System;
using EDUHOME.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EDUHOME.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210516143002_ChangeEventTableColumnTypeDateTime")]
    partial class ChangeEventTableColumnTypeDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EDUHOME.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactUs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bio");
                });

            modelBuilder.Entity("EDUHOME.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Comment")
                        .HasColumnType("int");

                    b.Property<DateTime>("Posted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İmageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EDUHOME.Models.BlogDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId")
                        .IsUnique();

                    b.ToTable("BlogDetail");
                });

            modelBuilder.Entity("EDUHOME.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EDUHOME.Models.DetailCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assesments")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.Property<string>("Certification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.Property<string>("HowToApply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("SkillLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.Property<DateTime?>("Starts")
                        .HasColumnType("datetime2");

                    b.Property<int>("Students")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("DetailCourses");
                });

            modelBuilder.Entity("EDUHOME.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventEndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EventTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lesson")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EDUHOME.Models.EventDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("ExactLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("EventDetail");
                });

            modelBuilder.Entity("EDUHOME.Models.EventSpeaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("SpeakerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("EventSpeakers");
                });

            modelBuilder.Entity("EDUHOME.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("TitleBottom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("EDUHOME.Models.Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("EDUHOME.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("EDUHOME.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(155)")
                        .HasMaxLength(155);

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EDUHOME.Models.TeacherDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Call")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Communication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Design")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Development")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faculty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Innovation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("TeamLeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("TeacherDetail");
                });

            modelBuilder.Entity("EDUHOME.Models.TeacherSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SocialId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocialId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSocial");
                });

            modelBuilder.Entity("EDUHOME.Models.BlogDetail", b =>
                {
                    b.HasOne("EDUHOME.Models.Blog", "Blog")
                        .WithOne("BlogDetail")
                        .HasForeignKey("EDUHOME.Models.BlogDetail", "BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUHOME.Models.DetailCourse", b =>
                {
                    b.HasOne("EDUHOME.Models.Course", "Course")
                        .WithOne("DetailCourse")
                        .HasForeignKey("EDUHOME.Models.DetailCourse", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUHOME.Models.EventDetail", b =>
                {
                    b.HasOne("EDUHOME.Models.Event", "Event")
                        .WithOne("EventDetail")
                        .HasForeignKey("EDUHOME.Models.EventDetail", "EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUHOME.Models.EventSpeaker", b =>
                {
                    b.HasOne("EDUHOME.Models.Event", "Event")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDUHOME.Models.Speaker", "Speaker")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUHOME.Models.TeacherDetail", b =>
                {
                    b.HasOne("EDUHOME.Models.Teacher", "Teacher")
                        .WithOne("TeacherDetail")
                        .HasForeignKey("EDUHOME.Models.TeacherDetail", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUHOME.Models.TeacherSocial", b =>
                {
                    b.HasOne("EDUHOME.Models.Social", "Social")
                        .WithMany("TeacherSocials")
                        .HasForeignKey("SocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDUHOME.Models.Teacher", "Teacher")
                        .WithMany("TeacherSocials")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
