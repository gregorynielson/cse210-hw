

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

    

    
}