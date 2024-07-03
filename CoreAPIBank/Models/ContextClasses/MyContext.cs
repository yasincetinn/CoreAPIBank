using CoreAPIBank.Models.Entities;
using CoreAPIBank.Models.Seed;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIBank.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<UserCardInfo> CardInfoes { get; set; }
    }
}
