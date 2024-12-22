using codingtr.Data.Abstract;
using codingtr.Models;
using codingtr.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

namespace codingtr.Data.Concrete.EfCore
{
    public class EfPostRepository : IPostRepository
    {
        private readonly DataContext _context;

        public EfPostRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<Post> Post => _context.Post;

        public void CreatePost(Post post)
        {
            _context.Post.Add(post); ;
            _context.SaveChanges();
        }

    


    }
}
