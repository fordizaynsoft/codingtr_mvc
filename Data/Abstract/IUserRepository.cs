using codingtr.Models;

namespace codingtr.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> User { get; }
        IQueryable<User> GetAllUser { get; }
        void CreateUser(User user);
    }
}
