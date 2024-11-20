using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoCycleAPI.Models
{
    public class Telephone
    {
        [Key]
        public int TelephoneId { get; set; }

        [MaxLength(10)]
        public string DDD { get; set; }

        [MaxLength(25)]
        public string Number { get; set; }

        [ForeignKey("Profile")]
        public string ProfileCPF { get; set; }
        public Profile Profile { get; set; }
    }
}
