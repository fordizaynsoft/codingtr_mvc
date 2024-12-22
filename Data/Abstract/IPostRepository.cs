using codingtr.Models;

namespace codingtr.Data.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Post { get; }
        void CreatePost(Post post);
    }
}
