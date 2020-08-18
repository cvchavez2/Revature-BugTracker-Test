using System.Collections.Generic;

namespace BugTracker.Domain.Models
{
  public class Project : AModel
  {
    public Project()
    {
      Tickets = new List<Ticket>();
      Developers = new List<Developer>();
      Managers = new List<Manager>();
    }
    public List<Ticket> Tickets { get; set; }
    public List<Developer> Developers { get; set; }
    public List<Manager> Managers { get; set; }

  }
}
