using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<NewsMdl> NewsMdls { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<GroupTeacher> GroupTeachers { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<GalleryVideo> GalleryVideos { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    RoleName = "Администратор"
                },
                new Role
                {
                    Id = 2,
                    RoleName = "Пользователь"
                },
                new Role()
                {
                    Id=3,
                    RoleName = "Преподаватель"
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UsrId = 1,
                    Login = "admin",
                    Pass = "admin",
                    RoleId = 1
                });
            base.OnModelCreating(modelBuilder);
        }

    }
}
