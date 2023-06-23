using DifficultyLevels.Enemies;

namespace DifficultyLevels;

public interface ILevelFactory
{
    public List<Enemy> GenerateEnemies();
}