namespace BugTracker.Domain.Models
{
  public abstract class AUser
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }

  }
}
