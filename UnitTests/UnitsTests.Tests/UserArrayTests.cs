using System.Security.Cryptography.X509Certificates;
using UnitTestsLab;

namespace UnitsTests.Tests;

[TestClass]
public class UserArrayTests
{
    private List<IUser> _users = new List<IUser>()
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

    private static IEnumerable<object[]> UsersWithCorrectParameters
    {
        get
        {
            return new[]
            {
                new object[] { new RegularUser("Qwei", 18, 3535), new PremiumUser("Qweo", 18, 35350) },
                new object[] { new RegularUser("Asdi", 19, 2525), new PremiumUser("Asdo", 19, 25250) },
                new object[] { new RegularUser("Zxci", 20, 1515), new PremiumUser("Zxco", 20, 15150) },
                new object[] { new RegularUser("Rtyi", 21, 646), new PremiumUser("Rtyo", 21, 6460) },
                new object[] { new RegularUser("Ghji", 22, 1234), new PremiumUser("Ghjo", 22, 12340) }
            };
        }
    }
    
    private static IEnumerable<object[]> UsersNotCorrectParameters
    {
        get
        {
            return new[]
            {
                new object[] { "wr", -5, -10},
                new object[] { "m", -5, -10},
                new object[] { "wr", -35, -10},
                new object[] { "vds", -5, -76},
                new object[] { "wg", -5, -10}
            };
        }
    }

    [TestMethod]
    public void UsersArraysAreEquivalent()
    {
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

        CollectionAssert.AreEquivalent(_users, users);
    }

    [TestMethod]
    [DynamicData(nameof(UsersWithCorrectParameters))]
    public void UserParametersFromDynamicDataCorrect(RegularUser regularUser, PremiumUser premiumUser)
    {
        Assert.IsTrue(regularUser.Name.Length > 3 && regularUser.Balance >= 0 && regularUser.Age >= 0 && regularUser.RegistrationTime != default);
        Assert.IsTrue(premiumUser.Name.Length > 3 && premiumUser.Balance >= 0 && premiumUser.Age >= 0 && premiumUser.RegistrationTime != default);
    }

    [TestMethod]
    [DynamicData(nameof(UsersNotCorrectParameters))]
    [ExpectedException(typeof(Exception))]
    public void UsersWithNotCorrectParametersFromDynamicData_ThrowingException(string name, int age, int balance)
    {
        var regUser = new RegularUser(name, (uint)age, (uint)balance);
        var premUser = new PremiumUser(name, (uint)age, (uint)balance);
    }
}