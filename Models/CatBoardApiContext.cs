using Microsoft.EntityFrameworkCore;

namespace CatBoardApi.Models
{
    public class CatBoardApiContext : DbContext
    {
        public CatBoardApiContext(DbContextOptions<CatBoardApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Board>()
            .HasData(
                new Board { BoardId = 1, Name = "Cat's Standing Up", Description = "Cats standing on their hind legs"},
                new Board { BoardId = 2, Name = "Cat's Being Cute", Description = "Cats"},
                new Board { BoardId = 3, Name = "Cat Fight", Description = "Fighting cats"},
                new Board { BoardId = 4, Name = "Cats be cattin", Description = "Cats living like tomorrow doesn't matter."}
            );
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}