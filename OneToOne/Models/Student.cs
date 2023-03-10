using System.ComponentModel.DataAnnotations;

namespace OneToOne.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public StudentAddress Address { get; set; }

    }
}
