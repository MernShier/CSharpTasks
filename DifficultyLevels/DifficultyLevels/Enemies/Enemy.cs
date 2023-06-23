namespace DifficultyLevels.Enemies;

public abstract class Enemy
{
    protected Enemy(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public int Health { get; private set; }
    public int Damage { get; private set; }

    public void Attack()
    {
        
    }
}