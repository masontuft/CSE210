public class User
{

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

        var lines = File.ReadAllLines(filename).Skip(1);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            User user = new User();
            user.StravaUserId = int.Parse(parts[0]);
            user.FirstName = parts[1].Trim('"',' ');
            user.LastName = parts[2].Trim('"',' ');
            user.StravaAccessToken = parts[3].Trim('"');
            user.StravaRefreshToken = parts[4].Trim('"');
            user.StravaAccessTokenExpiresAt = int.Parse(parts[5]);
            user.ExpoPushToken = parts[6].Trim('"');
            user.ShopToken = parts[7].Trim('"');
            user.Email = parts[8].Trim('"');
            user.ShopActivity = parts[9].Trim('"');
            UsersList.Add(user);
        }
        
    }
    public User()
    {
        // Basic constructor
    }

    public string GetUser()
    {
        return $"First Name: {FirstName}, \nLast Name: {LastName}, \nStrava User ID: {StravaUserId}, \nStrava Access Token: {StravaAccessToken}, \nStrava Refresh Token: {StravaRefreshToken}, \nStrava Access Token Expires At: {StravaAccessTokenExpiresAt}, \nExpo Push Token: {ExpoPushToken}, \nShop Token: {ShopToken}, \nEmail: {Email}, \nShop Activity: {ShopActivity}\n\n";
    }
}