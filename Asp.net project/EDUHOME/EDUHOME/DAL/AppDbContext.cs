using EDUHOME.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<DetailCourse> DetailCourses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetail { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherDetail> TeacherDetail {get;set;}
        public DbSet<Social> Socials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetail { get; set; }
        public DbSet<Subsciber> Subscibers  { get; set; }





    }

}