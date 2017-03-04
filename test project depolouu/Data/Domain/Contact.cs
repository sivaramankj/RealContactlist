using System.ComponentModel.DataAnnotations;

namespace Data.Domain
{
    public class Contact
    {
        public Contact()
        {
            Address = new Address();
        }

        [Key]
        public int ContactId { get; set; }
        [Required(ErrorMessage ="Empty Not Allowed")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Empty Not Allowed")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Empty Not Allowed")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        [StringLength(50)]
        public string Phone { get; set; }
        public Address Address { get; set; }
    }
}
