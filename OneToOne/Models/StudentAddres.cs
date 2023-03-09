using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneToOne.Models
{
    public class Address
    {
        [Key]
        public short AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public short StudentId { get; set; }
    }
}
