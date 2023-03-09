using System.ComponentModel.DataAnnotations;

namespace OneToOne.Models
{
    public class Student
    {
        [Key]
        public short Id { get; set; }
       
        public string Name { get; set; }
       
        public StudentAddres Address { get; set; }
    }
}
