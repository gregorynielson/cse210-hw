

public class Address 
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public Address(int customerIndex)
    {
        string[] customers = File.ReadAllLines("customers.txt");
        string newCustomer = customers[customerIndex];
        string[] nameAndAddress = newCustomer.Split(new string[] {"|"}, StringSplitOptions.None);
        string address = nameAndAddress[1];

        string[] addressParts = address.Split(new string[] {","}, StringSplitOptions.None);
        _street = addressParts[0].Trim();
        _city = addressParts[1].Trim();
        _country = addressParts[2];

    }

    public void PrintAddress()
    {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city},{_country}");
    }

    public bool InUsa()
    {
        if (_country.Trim() == "USA")
        {
            return true;
        }else{
            return false;
        }
    }

    public string CreateAddress()
    {
        string address = $"{_street},{_city} {_state},{_country}";
        return address;
    }
}