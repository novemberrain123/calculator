using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace calculator.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [DefaultValue("")]
        public string? Results { get; set; } = ""; // delimited by spaces
    }
}
