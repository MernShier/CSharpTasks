namespace UnitTestsLab;

public class RegularUser : IUser
{
    public RegularUser(string name, uint age, uint balance)
    {
        if (name.Length <= 3)
        {
            throw new Exception("Name is too short");
        }
        
        Name = name;
        Age = age;
        Balance = balance;

        Random rnd = new Random();
        RegistrationTime = new DateTime(rnd.Next(2000,2200), rnd.Next(1,13), rnd.Next(1,29), rnd.Next(1,24), rnd.Next(1,60), rnd.Next(1,60));
    }

    public string Name { get; set; }
    public uint Age { get; set; }
    public uint Balance { get; set; }
    public DateTime RegistrationTime { get; set; }
    public string Promotions { get; set; }
    
    public void Enter()
    {
        Console.WriteLine($"Hello {Name}");
    }

    public void StartApp()
    {
        Console.WriteLine($"Balance: {Balance}");
        if (Promotions != null)
        {
            Console.WriteLine($"Promotions: {Promotions}");
        }
    }
    
    public override bool Equals(object obj)
    {
        return obj.GetType() == GetType();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(GetType());
    }
}