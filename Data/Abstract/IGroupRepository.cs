using codingtr.Models;

namespace codingtr.Data.Abstract
{
    public interface IGroupRepository
    {
        IQueryable<Group> Group { get; }
    
    }
}
