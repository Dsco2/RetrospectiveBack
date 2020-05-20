using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Maps;

namespace Persistence
{
    public class MainContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}