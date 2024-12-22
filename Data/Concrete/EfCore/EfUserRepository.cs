using codingtr.Data.Abstract;
using codingtr.Models;
using codingtr.Data.Concrete.EfCore;

namespace codingtr.Data.Concrete.EfCore
{
    public class EfUserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public EfUserRepository(DataContext context)
        {
            _context = context;
        }
        public IQueryable<User> User => _context.User;
        public IQueryable<User> GetAllUser => _context.User;

        public void CreateUser(User user)
        {
            _context.User.Add(user); ;
            _context.SaveChanges();
        }
    }
}
