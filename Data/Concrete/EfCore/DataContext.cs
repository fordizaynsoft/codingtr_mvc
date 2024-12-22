
using Microsoft.EntityFrameworkCore;
using codingtr.Models;

namespace codingtr.Data.Concrete.EfCore
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<DevelopmentTopic> DevelopmentTopic { get; set; }
        public DbSet<Group> Group { get; set; }

    }
}
