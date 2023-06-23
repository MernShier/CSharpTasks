using DifficultyLevels.Enemies;

namespace DifficultyLevels;

public class HardLevelFactory: ILevelFactory
{
    public List<Enemy> GenerateEnemies()
    {
        var enemies = new List<Enemy>();
        Random rnd = new Random();
        var enemiesCount = rnd.Next(0, 50);

        for (int i = 0; i < enemiesCount; i++)
        {
            var enemyType = rnd.Next(1, 4);
            switch (enemyType)
            {
                case 1:
                    enemies.Add(new Wolf(rnd.Next(100,210),rnd.Next(20,410)));
                    break;
                case 2:
                    enemies.Add(new Bear(rnd.Next(100,410),rnd.Next(200,210)));
                    break;
                case 3:
                    enemies.Add(new Bee(rnd.Next(100,150),rnd.Next(300,710)));
                    break;
            }
        }

        return enemies;
    }
}