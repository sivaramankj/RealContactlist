using System.ComponentModel.DataAnnotations;

namespace Data.Domain
{
    public class Address
    {
        [StringLength(200, ErrorMessage = "cannot exceed 200 characters. ")]
        public string Street { get; set; }
        public string City { get; set; }
        [StringLength(100, ErrorMessage = "cannot exceed 100 characters. ")]
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
