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
            modelBuilder.Entity<Student>()
                .HasKey(s => s.MatNo);

            modelBuilder.Entity<Student>()
                .Property(s => s.MatNo)
                .ValueGeneratedOnAdd();
        }
    }
}
