using Microsoft.EntityFrameworkCore;

namespace OneToOne.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) :
           base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Address)
                .WithOne(ad => ad.StudentId)
                .HasForeignKey<StudentAddress>(ad => ad.StudentId);
        }



            //}
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
    }
}
