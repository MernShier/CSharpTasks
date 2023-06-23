using DifficultyLevels.Enemies;

namespace DifficultyLevels;

public class MediumLevelFactory : ILevelFactory
{
    public List<Enemy> GenerateEnemies()
    {
        var enemies = new List<Enemy>();
        Random rnd = new Random();
        var enemiesCount = rnd.Next(0, 20);

        for (int i = 0; i < enemiesCount; i++)
        {
            var enemyType = rnd.Next(1, 4);
            switch (enemyType)
            {
                case 1:
                    enemies.Add(new Wolf(rnd.Next(10,21),rnd.Next(20,41)));
                    break;
                case 2:
                    enemies.Add(new Bear(rnd.Next(10,41),rnd.Next(20,21)));
                    break;
                case 3:
                    enemies.Add(new Bee(rnd.Next(10,15),rnd.Next(30,71)));
                    break;
            }
        }

        return enemies;
    }
}