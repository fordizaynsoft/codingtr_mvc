using System.ComponentModel.DataAnnotations;
namespace codingtr.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [StringLength(6, ErrorMessage = "En fazla 6 karakter")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [Display(Name = "EMail")]
        public string? Email { get; set; }
        public string? UserRole { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [Display(Name = "Şifre")]
        public string? Password { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? ImageFile { get; set; }
    }
}
