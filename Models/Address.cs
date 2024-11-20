using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoCycleAPI.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [MaxLength(100)]
        public string Street { get; set; } = string.Empty;

        [MaxLength(100)]
        public string AdditionalInfo { get; set; } = string.Empty;

        public int Number { get; set; }

        [MaxLength(100)]
        public string City { get; set; } = string.Empty;

        [MaxLength(100)]
        public string State { get; set; } = string.Empty;

        [MaxLength(100)]
        public string ZipCode { get; set; } = string.Empty;

        [ForeignKey("Profile")]
        public string ProfileCPF { get; set; } = string.Empty;

        public Profile Profile { get; set; } = null!;
    }
}
