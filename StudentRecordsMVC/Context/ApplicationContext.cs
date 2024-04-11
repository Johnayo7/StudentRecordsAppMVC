using Microsoft.EntityFrameworkCore;
using StudentRecordsMVC.Models.Domain;

namespace StudentRecordsMVC.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define primary key for the Student entity
            modelBuilder.Entity<Student>()
                .HasKey(s => s.MatNo);

            // Ensure MatNo is generated on add
            modelBuilder.Entity<Student>()
                .Property(s => s.MatNo)
                .ValueGeneratedOnAdd();

        }
    }
}
