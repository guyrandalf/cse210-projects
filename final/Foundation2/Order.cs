using System;

public class Order
{
    private List<Product> _productsList;
    private Customer _customer;
    private float _totalPrice;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _productsList = products;
    }

    public float CalculateTotalPrice()
    {
        _totalPrice = 0;
        foreach (Product product in _productsList)
        {
            _totalPrice += product.CalculatePrice();
        }
        return _totalPrice;
    }

    public float CalculateShipping()
    {
        if (_customer.OutsideorInside())
        {
            return _totalPrice += 5;
        }
        else
        {
            return _totalPrice += 35;
        }
    }

    public void CreatePackingSlip()
    {
        string finalProduct = "";
        foreach (Product product in _productsList)
        {
            finalProduct = $"{product.GetId()} - {product.GetName()}";
            Console.WriteLine(finalProduct);
        }
    }

    public void CreateShippingSlip()
    {
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetAddress());
    }
}
