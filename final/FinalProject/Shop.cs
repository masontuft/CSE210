public class Shop
{
    public int Id;
    public string ShopName;
    public string Email;
    public string Password;
    public string SubId;
    public string InvoiceId;
    public string PlanType;
    public string ShopCode;
    public string ShopToken;
    public string PhoneNumber; 
    public string SubActivity;
    public string Auth0SubId;
    public List<Bike> Bikes = new List<Bike>();
    public List<Shop> ShopsList = new List<Shop>();

    public Shop()
    {
        // Empty constructor
    }

    public Shop(string filename)
    {
        var lines = File.ReadAllLines(filename).Skip(1);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Shop shop = new Shop();
            shop.Id = int.Parse(parts[0]);
            shop.ShopName = parts[1].Trim('"');
            shop.Email = parts[2].Trim('"');
            shop.Password = parts[3].Trim('"');
            shop.SubId = parts[4].Trim('"');
            shop.InvoiceId = parts[5].Trim('"');
            shop.PlanType = parts[6].Trim('"');
            shop.ShopCode = parts[7].Trim('"');
            shop.ShopToken = parts[8].Trim('"');
            shop.PhoneNumber = parts[9].Trim('"');
            shop.SubActivity = parts[10].Trim('"');
            shop.Auth0SubId = parts[11].Trim('"');
            ShopsList.Add(shop);

        }
    }
    
    public void DisplayShopByIndex(List<Shop> Shops, int index)
    {
        if (index < 0 || index >= Shops.Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }
        Shop shop = Shops[index];
        shop.Display();
        // Console.WriteLine($"Shop ID: {shop.Id}");
        // Console.WriteLine($"Shop Name: {shop.ShopName}");
        // Console.WriteLine($"Email: {shop.Email}");
        // Console.WriteLine($"Password: {shop.Password}");
        // Console.WriteLine($"Sub ID: {shop.SubId}");
        // Console.WriteLine($"Invoice ID: {shop.InvoiceId}");
        // Console.WriteLine($"Plan Type: {shop.PlanType}");
        // Console.WriteLine($"Shop Code: {shop.ShopCode}");
        // Console.WriteLine($"Shop Token: {shop.ShopToken}");
        // Console.WriteLine($"Phone Number: {shop.PhoneNumber}");
        // Console.WriteLine($"Sub Activity: {shop.SubActivity}");
        // Console.WriteLine($"Auth0 Sub ID: {shop.Auth0SubId}");
    }
    public void DisplayShops(List<Shop> Shops)
    {
        foreach (Shop shop in Shops)
        {
            Console.WriteLine($"Shop ID: {shop.Id}");
            Console.WriteLine($"Shop Name: {shop.ShopName}");
            Console.WriteLine($"Email: {shop.Email}");
            Console.WriteLine($"Password: {shop.Password}");
            Console.WriteLine($"Sub ID: {shop.SubId}");
            Console.WriteLine($"Invoice ID: {shop.InvoiceId}");
            Console.WriteLine($"Plan Type: {shop.PlanType}");
            Console.WriteLine($"Shop Code: {shop.ShopCode}");
            Console.WriteLine($"Shop Token: {shop.ShopToken}");
            Console.WriteLine($"Phone Number: {shop.PhoneNumber}");
            Console.WriteLine($"Sub Activity: {shop.SubActivity}");
            Console.WriteLine($"Auth0 Sub ID: {shop.Auth0SubId}");
        }
    }
    public void Display()
    {
        Console.WriteLine($"Shop Name: {ShopName}");
        Console.WriteLine();
        Console.WriteLine($"Shop ID: {Id}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Password: {Password}");
        Console.WriteLine($"Sub ID: {SubId}");
        Console.WriteLine($"Invoice ID: {InvoiceId}");
        Console.WriteLine($"Plan Type: {PlanType}");
        Console.WriteLine($"Shop Code: {ShopCode}");
        Console.WriteLine($"Shop Token: {ShopToken}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Sub Activity: {SubActivity}");
        Console.WriteLine($"Auth0 Sub ID: {Auth0SubId}");
    }
}

