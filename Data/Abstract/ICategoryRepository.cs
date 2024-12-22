using codingtr.Models;

namespace codingtr.Data.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Category { get; }
    
    }
}
