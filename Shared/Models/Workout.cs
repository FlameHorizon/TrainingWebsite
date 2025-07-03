namespace Shared.Models;

public class Workout
{
    public int Id { get; set; }
    public int WorkoutPlanId { get; set; }
    public string Name { get; set; }
    public IEnumerable<Exercise> Exercises { get; set; }
}