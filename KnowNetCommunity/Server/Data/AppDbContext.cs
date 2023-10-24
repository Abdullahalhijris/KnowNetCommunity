using KnowNetCommunity.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace KnowNetCommunity.Server.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(e => e.Scheduler)
                .WithOne(e => e.Student)
                .HasForeignKey<Scheduler>(e => e.Sid);

            modelBuilder.Entity<Student>()
                           .HasMany(s => s.courses)
                           .WithMany(c => c.students)
                           .UsingEntity(j => j.ToTable("StudentCourses"));



        }


        DbSet<Admin> admins { get; set; }
        DbSet<Course> courses { get; set; }
        DbSet<FileMangaer> fileMangaers { get; set; }
        DbSet<Major> majors { get; set; }
        DbSet<Scheduler> schedulers { get; set; }
        DbSet<Student> students { get; set; }



    }

}
