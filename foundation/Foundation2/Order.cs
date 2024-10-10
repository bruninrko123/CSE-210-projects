public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
        
    }

    public double CalculateTotalOrderCost()
    {   
        double totalCost = 0;
        foreach (Product p in _products)
        {
            totalCost = totalCost + p.TotalProductPrice();
        }

        if (_customer.livesInTheUs() == true)
        {
            totalCost = totalCost + 5;
        }
        else if (_customer.livesInTheUs() == false)
        {
            totalCost = totalCost + 35;
        }
        return totalCost;
    }

    public string PackingLabel()
    {   
        string Label = "";
        foreach (Product p in _products)
        {
            Label = Label + "\n" + $"product: {p.GetName()}  ID: {p.GetId()}";
            
        }
        return Label;
    }

    public string ShippingLabel()
    {
        string Label =_customer.GetCustomerName() + "\n"+ _customer.GetCustomerAdress();
        return Label;
    }

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }
}