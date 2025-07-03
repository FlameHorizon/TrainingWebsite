using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Shared;

public class AppDbContext : DbContext
{
    public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<Exercise> Exercises { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // These servers are internal, so as long as you don't connect to my WIFI/network, or hack by VPN
        // you can't get in. Sorry.
#if RELEASE
        var user = Environment.GetEnvironmentVariable("DB_USERNAME");
        if (user is null)
        {
           throw new InvalidOperationException("The environment variable DB_USERNAME is not set."); 
        }
        
        var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        if (password is null)
        {
            throw new InvalidOperationException("The environment variable DB_PASSWORD is not set."); 
        }
        var connectionString = $"Server=10.0.3.3;Port=3306;Database=TrainingAppDb_DEV;User={user};Password={password};";
#else
        var connectionString = "Server=192.168.18.5;Port=32768;Database=TrainingAppDb_DEV;User=root;Password=pass;";
#endif
        var version = new MySqlServerVersion(new Version(9, 2, 0));
        optionsBuilder.UseMySql(connectionString, version);
        base.OnConfiguring(optionsBuilder);
    }
}