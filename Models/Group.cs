using System.ComponentModel.DataAnnotations;
namespace codingtr.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; } = null!;     
        public DateTime? CreatedAt { get; set; }


    }
}
