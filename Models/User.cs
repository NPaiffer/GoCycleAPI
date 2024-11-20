using System.ComponentModel.DataAnnotations;

namespace GoCycleAPI.Models
{
public class User
{
    [Key]
    public int UserId { get; set; }

    [Required, MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string Password { get; set; } = string.Empty;

    [MaxLength(100)]
    public string Status { get; set; } = string.Empty;

    public ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}

}
