using BlazorApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base(options) { }
        public DbSet<Course> courses { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<Student> students { get; set; }

    }
}
