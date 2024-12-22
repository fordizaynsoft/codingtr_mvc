using codingtr.Data.Abstract;
using codingtr.Models;
using codingtr.Data;


namespace codingtr.Data.Concrete.EfCore
{
    public class EfGroupRepository : IGroupRepository
    {
        private readonly DataContext _context;

        public EfGroupRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<Group> Group => _context.Group;

  

    


    }
}
