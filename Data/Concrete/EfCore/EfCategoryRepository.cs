using codingtr.Data.Abstract;
using codingtr.Models;
using codingtr.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

namespace codingtr.Data.Concrete.EfCore
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public EfCategoryRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<Category> Category => _context.Category;

  

    


    }
}
