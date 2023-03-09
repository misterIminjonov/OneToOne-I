using Microsoft.EntityFrameworkCore;

namespace OneToOne.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) :
           base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Student>()
        //    //    .HasOne(s => s.Address)
        //    //    .WithOne(ad => ad.Student)
        //    //    .HasForeignKey<StudentAddres>(ad => ad.StudentId);


            
        //}
        public DbSet<Student> students { get; set; }
        public DbSet<StudentAddres> studentsAddres { get; set; }
    }
}
