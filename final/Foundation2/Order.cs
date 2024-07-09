using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalculateTotalCost()
    {
        float totalCost = _products.Sum(product => product.GetTotalCost());
        totalCost += CalculateShippingCost();
        return (float)Math.Round(totalCost, 2);
    }

    private float CalculateShippingCost()
    {
        if (_customer.GetAddress().IsUSA())
        {
            return 5.00f;
        }

        else
        {
            return 35.00f;
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing List:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetProductName()} - {product.GetQuantity()} units\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Ship to:\n{_customer.GetCustomerName()},\n{_customer.GetAddress().GetFullAddress()}";
    }
}
