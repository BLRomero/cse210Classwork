using System;
using System.Security.Cryptography;

public class Product
{
    private string _productName;
    private int _productID;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string productName, int productID, float pricePerUnit, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public int GetProductID()
    {
        return _productID;
    }
    public float GetPricePerUnit()
    {
        return _pricePerUnit;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public float GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

}