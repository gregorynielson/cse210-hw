using System.Collections.Generic;

public class Order 
{
    private List<string> _products = new List<string>()
    {
        
    };
    private List<string> _eachItem = new List<string>()
    {

    };

    private Customer _customer;
    private Address _address;
    private Product _product;

    public Order(Customer customer, Address address, Product product)
    {
        _customer = customer;
        _address = address;
        _product = product;
    }
    


    public void GetPackingLabel(int _orderNum)
    {
        Console.WriteLine("");
        Console.WriteLine("--Packing List--");
        // for each item in list:
        if (_orderNum == 1)
        {
            _products = GetOrderProduct(0, 2, 4);
            foreach (string item in _products)
            {
                _eachItem = item.Split(",").ToList();
                Console.WriteLine($"Item: {_eachItem[0].Trim()} - Product ID: {_eachItem[1].Trim()}");
            }
            double _productSum = _product.ComputePrice(_orderNum);
            Console.WriteLine($"Subtotal: ${_productSum}");
            bool _shipRate = _address.InUsa();
            if (_shipRate == true)
            {
                Console.WriteLine("Shipping Rate: $5.00");
                double _total = _productSum + 5;
                Console.WriteLine($"Total: ${_total}");
            }else
            {
                Console.WriteLine("Shipping Rate: $35.00");
                double _total = _productSum + 35;
                Console.WriteLine($"Total: ${_total}"); 
            }

            
        }else
        {
            _products = GetOrderProduct(1, 3, 5);
            foreach (string item in _products)
            {
                _eachItem = item.Split(",").ToList();
                Console.WriteLine($"Item: {_eachItem[0].Trim()} - Product ID: {_eachItem[1].Trim()}");
            }
            double _productSum = _product.ComputePrice(_orderNum);
            Console.WriteLine($"Subtotal: ${_productSum}");
            bool _shipRate = _address.InUsa();
            if (_shipRate == true)
            {
                Console.WriteLine("Shipping Rate: $5.00");
                double _total = _productSum + 5;
                Console.WriteLine($"Total: ${_total}");
            }else
            {
                Console.WriteLine("Shipping Rate: $35.00");
                double _total = _productSum + 35;
                Console.WriteLine($"Total: ${_total}"); 
            }
            
        }
        
    
    }



    public void GetShippingLabel()
    {
        Console.WriteLine("--Shipping Label--");
        _customer.PrintName();
        _address.PrintAddress();
        
    }

    public List<string> GetOrderProduct(int first, int second, int third)
    {
        List<string> newOrder = new List<string>();
        string[] items = File.ReadAllLines("products.txt");
        newOrder.Add(items[first]);
        newOrder.Add(items[second]);
        newOrder.Add(items[third]);
        return newOrder;
    }

    
}