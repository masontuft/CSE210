public class User
{
    // User-specific properties and methods can be defined here
    public int StravaUserId;
    public string FirstName;
    public string LastName;
    public string StravaAccessToken;
    public string StravaRefreshToken;
    public int StravaAccessTokenExpiresAt;
    public string ExpoPushToken;
    public string ShopToken;
    public string Email;
    public string ShopActivity;
    public static List<User> UsersList = new List<User>();

    public User(string filename)
    {
        // Skip the header row with Skip(1)
        var lines = File.ReadAllLines(filename).Skip(1);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            User user = new User();
            user.StravaUserId = int.Parse(parts[0]);
            user.FirstName = parts[1];
            user.LastName = parts[2];
            user.StravaAccessToken = parts[3];
            user.StravaRefreshToken = parts[4];
            user.StravaAccessTokenExpiresAt = int.Parse(parts[5]);
            user.ExpoPushToken = parts[6];
            user.ShopToken = parts[7];
            user.Email = parts[8];
            user.ShopActivity = parts[9];
            UsersList.Add(user);
        }
        
        // Now you can work with the users in the list
        // foreach (var user in UsersList)
        // {
        //     Console.WriteLine($"User: {user.FirstName} {user.LastName}, StravaUserId: {user.StravaUserId}");
        // }
    }
    public User()
    {
        
        // string filename = "users.csv";
        // Skip the header row with Skip(1)
        // var lines = File.ReadAllLines(filename).Skip(1);
        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(',');
        //     User user = new User();
        //     user.StravaUserId = int.Parse(parts[0]);
        //     user.FirstName = parts[1];
        //     user.LastName = parts[2];
        //     user.StravaAccessToken = parts[3];
        //     user.StravaRefreshToken = parts[4];
        //     user.StravaAccessTokenExpiresAt = int.Parse(parts[5]);
        //     user.ExpoPushToken = parts[6];
        //     user.ShopToken = parts[7];
        //     user.Email = parts[8];
        //     user.ShopActivity = parts[9];
        //     UsersList.Add(user);
        // }
        
        // // Now you can work with the users in the list
        // foreach (var user in UsersList)
        // {
        //     Console.WriteLine($"User: {user.FirstName} {user.LastName}, Email: {user.Email}");
        // }
    }
}