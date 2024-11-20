using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoCycleAPI.Models
{
    public class Profile
    {
        [Key]
        public string CPF { get; set; }

        public DateTime Birthdate { get; set; }

        [MaxLength(30)]
        public string Username { get; set; }

        public int Score { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        // Relacionamento 1:N
        public ICollection<Telephone> Telephones { get; set; }
    }
}
