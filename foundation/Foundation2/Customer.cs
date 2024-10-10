public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool livesInTheUs()
    {
        if (_address.isInUSA() == true)
        {
            return true;
        }
        else if (_address.isInUSA() == false)
        {
            return false;
        }
        else
        {
            return false;
        }
    }


    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAdress()
    {
       return _address.FullAddress();
    }
}
