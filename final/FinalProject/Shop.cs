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
    public long PhoneNumber; // Using long instead of int for phone numbers
    public string SubActivity;
    public string Auth0SubId;
    public List<Bike> Bikes = new List<Bike>();

    public Shop(string filename)
    {
        var lines = File.ReadAllLines(filename).Skip(1);
        foreach (string line in lines)
        {
            
        }
    }
    // {
    //     Bikes = new List<Bike>();

    // }
    
}

