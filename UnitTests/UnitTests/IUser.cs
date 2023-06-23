namespace UnitTestsLab;

public interface IUser
{
    public string Name { get; set; }
    public uint Age { get; set; }
    public uint Balance { get; set; }
    public DateTime RegistrationTime { get; set; }
    public string Promotions { get; set; }

    public void Enter()
    {
    }

    public void StartApp()
    {
    }
}