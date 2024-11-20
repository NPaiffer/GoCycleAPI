using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoCycleAPI.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [MaxLength(100)]
        public string Street { get; set; }

        [MaxLength(100)]
        public string? AdditionalInfo { get; set; }

        public int Number { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(100)]
        public string State { get; set; }

        [MaxLength(100)]
        public string ZipCode { get; set; }

        [ForeignKey("Profile")]
        public string ProfileCPF { get; set; }
        public Profile Profile { get; set; }
    }
}
