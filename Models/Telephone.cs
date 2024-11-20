using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoCycleAPI.Models
{
    public class Telephone
    {
        [Key]
        public int TelephoneId { get; set; }

        [MaxLength(10)]
        public string DDD { get; set; } = string.Empty;

        [MaxLength(25)]
        public string Number { get; set; } = string.Empty;

        [ForeignKey("Profile")]
        public string ProfileCPF { get; set; } = string.Empty;
        public Profile Profile { get; set; } = null!;
    }
}
