using codingtr.Data.Abstract;
using codingtr.Models;
using codingtr.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

namespace codingtr.Data.Concrete.EfCore
{
    public class EfDevelopmentTopicRepository : IDevelopmentTopicRepository
    {
        private readonly DataContext _context;

        public EfDevelopmentTopicRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<DevelopmentTopic> DevelopmentTopic => _context.DevelopmentTopic;

  

    


    }
}
