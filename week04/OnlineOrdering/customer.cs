

public class Customer 
{
    private string _name;
    private string _address;
    
    public Customer(int customerIndex)
    {
        string[] customers = File.ReadAllLines("customers.txt");
        string newCustomer = customers[customerIndex];
        string[] nameAndAddress = newCustomer.Split(new string[] {"|"}, StringSplitOptions.None);
        _name = nameAndAddress[0];
    }

    public void PrintName()
    {
        Console.WriteLine($"{_name}");
    }

    

    // public void SetAddress()
    // {
    //     Address address = new Address();
    //     _address = address.CreateAddress();
    // }

    // public string GetAddress()
    // {
    //     SetAddress();
    //     return _address;
    // }

    // public bool InUsa()
    // {
    //     // call method from address class
    //     // if loop to return true and false
    // }
}