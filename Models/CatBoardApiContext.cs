using Microsoft.EntityFrameworkCore;

namespace CatBoardApi.Models
{
    public class CatBoardApiContext : DbContext
    {
        public CatBoardApiContext(DbContextOptions<CatBoardApiContext> options)
            : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}