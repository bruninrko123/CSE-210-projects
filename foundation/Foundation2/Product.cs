public class Product
{
    private string _name;
    private string _productId;
    private int _quantity;
    private double _price;



public Product(string name, string productId, int quantity, double price)
{
    _name = name;
    _productId = productId;
    _quantity = quantity;
    _price = price;
}

public double TotalProductPrice()
{
    double totalPrice = _quantity * _price;
    return totalPrice;
}

public string GetName()
{
    return _name;
}

public string GetId()
{
    return _productId;
}
}