using UnitTestsLab;

namespace UnitsTests.Tests;

[TestClass]
public class UserTests
{
    private RegularUser _regularUser = new RegularUser("Qwerty",50,1234);
    private PremiumUser _premiumUser = new PremiumUser("Zxcvbn",55,1234567);
    
    [TestMethod]
    public void RegularAndPremiumUserParametersCorrect()
    {
        Assert.IsTrue(_regularUser.Name.Length > 3 && _regularUser.Balance >= 0 && _regularUser.Age >= 0 && _regularUser.RegistrationTime != default);
        Assert.IsTrue(_premiumUser.Name.Length > 3 && _premiumUser.Balance >= 0 && _premiumUser.Age >= 0 && _premiumUser.RegistrationTime != default);
    }
    
    [ExpectedException(typeof(Exception))]
    [TestMethod]
    public void  RegularAndPremiumUserParametersNotCorrect_ThrowingException()
    {
        var regularUser = new RegularUser("qwe", 25, 500);
        var premiumUser = new PremiumUser("zx", 11, 35);
    }
}