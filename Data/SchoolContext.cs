using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data 
{
  public class SchoolContext : DbContext
  {
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {

    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Student> Students { get; set; }

    // Normally EF creates tables that have the names the same as the DBSet Property names
    // In some cases, it might be preferred to have alternative names (i.e. singular vs plural, etc)
    // This next section overrides the default behaviour and specifies different table names
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Course>().ToTable("Course");
      modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
      modelBuilder.Entity<Student>().ToTable("Student");
    }
  }
}