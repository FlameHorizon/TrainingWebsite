namespace Shared.Models;

public class WorkoutPlan
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Workout> Workouts { get; set; }
}