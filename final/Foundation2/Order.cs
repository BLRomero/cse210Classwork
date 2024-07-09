using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
class Order
{

    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void addProduct(Product product)
    {
        _products.Add(product);
    }
    public float calculateTotalCost()
    {
        float _totalCost = 0;
        foreach (var product in _products)
        {
            _totalCost += product.GetTotalCost();

        }
        return _totalCost;
    }
    public string getPackingLabel()
    {
        string packingLabel = "Packing List:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetProductName()} - {product.GetQuantity()} units\n";
        }
        return packingLabel;
    }
    public string getShippingLabel()
    {
        return $"Ship to:\n{_customer.GetCustomerName()},\n{_customer.GetAddress().GetFullAddress()}";
    }
  
}