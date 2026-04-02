using System.Collections.Generic;

public class Product 
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    private List<string> _products = new List<string>()
    {
        
    };

    private List<string> _eachProduct = new List<string>()
    {

    };


    public List<string> GetOrderProduct(int first, int second, int third)
    {
        List<string> newOrder = new List<string>();
        string[] items = File.ReadAllLines("products.txt");
        newOrder.Add(items[first]);
        newOrder.Add(items[second]);
        newOrder.Add(items[third]);
        return newOrder;
    }

    public double ComputePrice(int orderNum)
    {
        if (orderNum == 1)
        {
            _products = GetOrderProduct(0, 2, 4);
            double _totalPrice = 0;
            foreach (string _product in _products)
            {
                _eachProduct = _product.Split(",").ToList();
                _price = double.Parse(_eachProduct[2]);
                _quantity = int.Parse(_eachProduct[3]);

                _totalPrice += _price * _quantity;
            }
            return _totalPrice;
        }else
        {
            _products = GetOrderProduct(1, 3, 5);
            double _totalPrice = 0;
            foreach (string _product in _products)
            {
                _eachProduct = _product.Split(",").ToList();
                _price = double.Parse(_eachProduct[2]);
                _quantity = int.Parse(_eachProduct[3]);
                _totalPrice += _price * _quantity;
            }
            return _totalPrice;
        }
        
        
    }

}