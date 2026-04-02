using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Customer cust1 = new Customer(2);
        Address add1 = new Address(2);
        Product prod1 = new Product();
        Order ord1 = new Order(cust1, add1, prod1);
        ord1.GetShippingLabel();
        ord1.GetPackingLabel(1);
        

        Console.WriteLine("");
        Console.WriteLine("");


        Customer cust2 = new Customer(4);
        Address add2 = new Address(4);
        Product prod2 = new Product();
        Order ord2 = new Order(cust2, add2, prod2);
        ord2.GetShippingLabel();
        ord2.GetPackingLabel(2);
        
    }
}