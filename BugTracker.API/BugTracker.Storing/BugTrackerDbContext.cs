using Microsoft.EntityFrameworkCore;
using BugTracker.Domain.Models;

namespace BugTracker.Storing
{
  public class BugTrackerDbContext : DbContext
  {
    public DbSet<Ticket> Tickets { get; set; } 
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Project> Projects { get; set; } 
    public DbSet<Developer> Developers { get; set; } 
    public DbSet<Manager> Managers { get; set; } 

    // public BugTrackerDbContext(DbContextOptions<BugTrackerDbContext> options) : base(options){} //dependency injection
    public BugTrackerDbContext(DbContextOptions options) : base(options){} //dependency injection
    // public BugTrackerDbContext(DbContextOptions<BugTrackerDbContext> options) : base(options){} //dependency injection

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Ticket>().HasKey(e => e.Id); //primary constraint
      builder.Entity<Comment>().HasKey(e => e.Id);
      builder.Entity<Project>().HasKey(e => e.Id);
      builder.Entity<Developer>().HasKey(e => e.Id);
      builder.Entity<Manager>().HasKey(e => e.Id);
    }
  }
}