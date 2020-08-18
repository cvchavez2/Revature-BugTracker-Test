using System.Collections.Generic;

namespace BugTracker.Domain.Models
{
  public class Project : AModel
  {
    public Project()
    {
      Tickets = new List<Ticket>();
      Users = new List<AUser>();
    }
    public List<Ticket> Tickets { get; set; }

    public List<AUser> Users { get; set; }

  }
}
