using codingtr.Models;

namespace codingtr.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string? ImageFile { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;


    }
}


//public int UserID { get; set; }
//public Users Users { get; set; } = null!;
