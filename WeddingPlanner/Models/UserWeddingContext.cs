using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Models
{
    public class UserWeddingContext : DbContext
    {
        public UserWeddingContext(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WeddingPlan> WeddingPlans { get; set; }
    }
    }
