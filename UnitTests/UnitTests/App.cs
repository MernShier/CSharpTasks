namespace UnitTestsLab;

public class App
{
    private List<IUser> _users;
    private List<IUser> _regularUsers, _premiumUsers;

    private int regularUsersWithPromotions, premiumUsersWithPromotions;

    public App(List<IUser> users)
    {
        _users = users;
        _regularUsers = new List<IUser>();
        _premiumUsers = new List<IUser>();

        foreach (var user in _users)
        {
            if (user is RegularUser)
            {
                _regularUsers.Add(user);
            }
            else if (user is PremiumUser)
            {
                _premiumUsers.Add(user);
            }
        }

        foreach (var user in _users)
        {
            AddPromotionsToUser(user);
        }
    }

    public void Login(string userName)
    {
        IUser user = _users.Find(user => user.Name == userName) ?? throw new ($"There is no user named {userName}");

        user.Enter();
        user.StartApp();
    }

    private void AddPromotionsToUser(IUser user)
    {
        if (user is RegularUser)
        {
            List<IUser> sortedByRegistrationTimeRegularUsers = new List<IUser>(_regularUsers.OrderBy(user => user.Age));

            if (regularUsersWithPromotions < 3)
            {
                sortedByRegistrationTimeRegularUsers[regularUsersWithPromotions].Promotions =
                    "Some regular user promotions";
                return;
            }
        }

        if (user is PremiumUser)
        {
            List<IUser> sortedByRegistrationTimePremiumUsers = new List<IUser>(_premiumUsers.OrderBy(user => user.Age));

            if (premiumUsersWithPromotions < 5)
            {
                sortedByRegistrationTimePremiumUsers[regularUsersWithPromotions].Promotions =
                    "Some premium user promotions";
                return;
            }
        }

        user.Promotions = null;
    }
}