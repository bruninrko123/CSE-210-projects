using System;

class Program
{
    static void Main(string[] args)
    {   

        //Creating an instance of the Adress class
        
        string street = "Shilick Street";
        string city = "Petrópolis";
        string state = "RJ";
        string country = "Brazil";
        //callind adress constructor
        Address address = new Address(street, city, state, country);

        //Creating an instance of the Customer class
        string customerName = "Bruno";
        Customer customer = new Customer(customerName, address);


        //Creating an instance of the first product
        string productName1 = "Phone";
        string productId1 = "PH257";
        int quantity1 = 12;
        double price1 = 2534.43;
        
        Product product1 = new Product(productName1,productId1,quantity1,price1);

        //Creating an instance of the second product
        string productName2 = "Airpods";
        string productId2 = "AIR787";
        int quantity2 = 15;
        double price2 = 50.5;
        
        Product product2 = new Product(productName2,productId2,quantity2,price2);
        
        // putting the customer and the products inside the order
        Order order1 = new Order(customer);
        order1.SetProduct(product1);
        order1.SetProduct(product2);









        // THIS IS THE  SECOND ORDER


        //Creating an instance of the Adress class
        
        string street2 = "Main Street";
        string city2 = "New York";
        string state2 = "NY";
        string country2 = "USA";
        //callind adress constructor
        Address address2 = new Address(street2, city2, state2, country2);

        //Creating an instance of the Customer class
        string customerName2 = "Keyan";
        Customer customer2 = new Customer(customerName2, address2);


        //Creating an instance of the first product
        string productName3 = "African Shirt";
        string productId3 = "AF674";
        int quantity3 = 20;
        double price3 = 65;
        
        Product product3 = new Product(productName3,productId3,quantity3,price3);

        //Creating an instance of the second product
        string productName4 = "Tiger Toy";
        string productId4 = "TT220";
        int quantity4 = 50;
        double price4 = 32.65;
        
        Product product4 = new Product(productName4,productId4,quantity4,price4);
        
        // putting the customer and the products inside the order
        Order order2 = new Order(customer2);
        order2.SetProduct(product3);
        order2.SetProduct(product4);



         //creating an instance of the Screen class
        Screen screen = new Screen();
        screen.GetOrder(order1);
        screen.GetOrder(order2);
        //display the screen
        screen.DisplayScreen();

    }
}