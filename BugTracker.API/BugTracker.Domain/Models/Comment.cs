using System;

namespace BugTracker.Domain.Models
{
  public class Comment : AModel
  {
    public string Commenter { get; set; }

    public string Message { get; set; }

    public DateTime DateSubmitted { get; set; }

  }
}
