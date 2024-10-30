using System.ComponentModel.DataAnnotations;

namespace PSPProyecto.Data.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [StringLength(80)]
        public string LastName { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(200)]
        public string Photo { get; set; }
    }
}
