using codingtr.Models;

namespace codingtr.Data.Abstract
{
    public interface IDevelopmentTopicRepository
    {
        IQueryable<DevelopmentTopic> DevelopmentTopic { get; }

    }
}




