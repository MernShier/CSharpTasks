using DifficultyLevels.Enemies;

namespace DifficultyLevels;

public class EasyLevelFactory : ILevelFactory
{
    public List<Enemy> GenerateEnemies()
    {
        var enemies = new List<Enemy>();
        Random rnd = new Random();
        var enemiesCount = rnd.Next(0, 10);

        for (int i = 0; i < enemiesCount; i++)
        {
            var enemyType = rnd.Next(1, 4);
            switch (enemyType)
            {
                case 1:
                    enemies.Add(new Wolf(rnd.Next(5,11),rnd.Next(10,21)));
                    break;
                case 2:
                    enemies.Add(new Bear(rnd.Next(5,21),rnd.Next(10,11)));
                    break;
                case 3:
                    enemies.Add(new Bee(rnd.Next(1,6),rnd.Next(20,51)));
                    break;
            }
        }

        return enemies;
    }
}