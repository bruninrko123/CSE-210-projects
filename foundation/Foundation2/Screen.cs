public class Screen
{
    private List<Order> _orders = new List<Order>();



    public Screen()
    {
       
    }


    public void GetOrder(Order order)
    {
        _orders.Add(order);
    }
    public void DisplayScreen()
    {   int x =0;
        foreach (Order o in _orders)
        {   
            x++;
            Console.WriteLine("\n");
            Console.WriteLine($"{x}º Order");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(o.PackingLabel());
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(o.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Total Price:");
            Console.WriteLine(o.CalculateTotalOrderCost());

        }
    }
}