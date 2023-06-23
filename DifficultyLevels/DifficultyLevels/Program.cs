using DifficultyLevels;
using DifficultyLevels.Enemies;

Console.WriteLine("Select difficulty level");

while (int.TryParse(Console.ReadLine(), out int input))
{
    ILevelFactory levelFactory;
    
    switch (input)
    {
        case 1:
            levelFactory = new EasyLevelFactory();
            break;
        case 2:
            levelFactory = new MediumLevelFactory();
            break;
        case 3:
            levelFactory = new HardLevelFactory();
            break;
        default:
            Console.WriteLine("Wrong Difficulty Level");
            return;
    }

    var level = levelFactory.GenerateEnemies();
}
