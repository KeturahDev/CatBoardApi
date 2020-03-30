using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CatBoardApi.Models
{
  public class Post
  {
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public int AuthorId { get; set; }
    public int BoardId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime EditDate { get; set; }
    public int Score { get; set; }

    public Post()
    {
      this.Comments = new HashSet<Comment>();
    }

    public ICollection<Comment> Comments { get; set; }
  }
}