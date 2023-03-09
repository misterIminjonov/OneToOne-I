using Microsoft.EntityFrameworkCore;

namespace OneToOne.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) :
           base(options)
        {

        }
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Connect=.\\user id=postgres; password=@isroilov_1929; server=localhost; port=5432; database=OneToOne; pooling=true");
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Address)
                .WithOne(ad => ad.Student)
                .HasForeignKey<StudentAddres>(ad => ad.AddressOfStudentId);


            
        }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentAddres> studentsAddres { get; set; }
    }
}
