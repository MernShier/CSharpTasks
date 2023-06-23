using UnitTestsLab;

var users = new List<IUser>()
{
    new RegularUser("Clinton", 75, 15),
    new RegularUser("Hugh", 15, 15),
    new RegularUser("Conrad", 15, 15),
    new RegularUser("Clyde", 95, 15),
    new PremiumUser("Howard", 50, 15000),
    new PremiumUser("Milton", 12, 15000),
    new PremiumUser("Asher", 13, 15000),
    new PremiumUser("Clement", 14, 15000),
    new PremiumUser("Jack", 15, 55000),
    new PremiumUser("Matthew", 3, 995000)
};

var app = new App(users);

Console.WriteLine("Enter user name");
while (true)
{
    app.Login(Console.ReadLine());
}