namespace Shared.Models;

public class Workout
{
    public int Id { get; set; }
    public int WorkoutPlanId { get; set; }
    public string Name { get; set; }
    public List<Exercise> Exercises { get; set; } = [];
}