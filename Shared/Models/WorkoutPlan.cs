namespace Shared.Models;

public class WorkoutPlan
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Workout> Workouts { get; set; } = [];

    /// <summary>
    /// User defined tag for the workout. This allows to group workouts together when displaying inside a summary graph.
    /// </summary>
    public string Tag { get; set; } = string.Empty;
}