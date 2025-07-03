namespace Shared.Models;

public class Exercise
{
    public int Id { get; set; }
    public int WorkoutId { get; set; }
    public int Reps { get; set; }
    public double Weight { get; set; }
    public bool Completed { get; set; }
    public bool Skipped { get; set; }
    
    
}