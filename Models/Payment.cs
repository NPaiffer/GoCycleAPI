using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoCycleAPI.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public float Amount { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }

        [ForeignKey("Usage")]
        public int UsageId { get; set; }
        public Usage Usage { get; set; }
    }
}
