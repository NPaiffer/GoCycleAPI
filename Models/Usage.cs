using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoCycleAPI.Models
{
    public class Usage
    {
        [Key]
        public int UsageId { get; set; }

        public DateTime PickupDatetime { get; set; }

        public DateTime ReturnDatetime { get; set; }

        public float Duration { get; set; }

        public int Score { get; set; }

        [ForeignKey("Profile")]
        public string ProfileCPF { get; set; }  = string.Empty;
        public Profile Profile { get; set; } = null!;
    }
}
