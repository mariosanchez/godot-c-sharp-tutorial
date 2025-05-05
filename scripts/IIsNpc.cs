using Godot;

public interface IIsNpc
{
    float DifficultyMultiplier { get; set; }
    
    void IncrementDifficulty()
    {
        GD.Print($"Difficulty increased. Currently at {DifficultyMultiplier}.");
        DifficultyMultiplier += 0.1f;
    }
}