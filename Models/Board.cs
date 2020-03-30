using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace CatBoardApi.Models
{
  public class Board
  {
    public int BoardId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Board()
    {
      this.Posts = new HashSet<Post>();
    }

    public virtual ICollection<Post> Posts { get; set; }
  }
    
}