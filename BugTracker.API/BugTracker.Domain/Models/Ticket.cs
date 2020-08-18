using System;
using System.Collections.Generic;

namespace BugTracker.Domain.Models
{
  public class Ticket : AModel
  {
    public Ticket()
    {
      Comments = new List<Comment>();
    }
    public string Title { get; set; }

    public string Submitter { get; set; }

    public int DevAssignedId { get; set; } // it could be a string:name

    public int Status { get; set; } // it could be a string as well

    public DateTime DateSubmitted { get; set; }

    public string Details { get; set; }

    public string Type { get; set; }

    public int Priority { get; set; } // could be string as well

    // public Project ProjReference { get; set; }
    public int ProjReferenceId { get; set; }

    public List<Comment> Comments { get; set; }

  }
}
