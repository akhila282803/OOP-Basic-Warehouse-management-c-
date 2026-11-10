using System;
using System.Data;
using System.Dynamic;
using System.Runtime.CompilerServices;

//Task 1 
class program
{
    static void Main()
    {
        Console.WriteLine("Welcome to warehouse  operated by robots");
        //task 2 testing
        //Product p1 = new Product("laptop");
        //Console.WriteLine(p1.Name);
        //Product p2 = new Product("");
        //Console.WriteLine(p2.Name);
        //task 4
        Product newproduct = new Product("phone");
        Order Neworder = new Order(newproduct);
        Console.WriteLine(Neworder.OrderedProduct.Name);
        Console.WriteLine(Neworder.State);

        //Task 7
        PackingRobot Newpackingrobot = new PackingRobot("PackingRobot");
        Newpackingrobot.ProcessOrder(Neworder);
        Console.WriteLine(Neworder.State);
        //Task 9
        DispatchRobot Newdispatchrobot = new DispatchRobot("DispatchRobot");
        Newdispatchrobot.ProcessOrder(Neworder);
        DeliveryRobot Newdeliveryrobot = new DeliveryRobot("DeliveryRobot");
        Newdeliveryrobot.ProcessOrder(Neworder);
        List<WarehouseRobot> creation = new List<WarehouseRobot>{
        Newpackingrobot, Newdispatchrobot, Newdeliveryrobot};
        foreach (WarehouseRobot item in creation)
        {
            item.ProcessOrder(Neworder);
            Console.WriteLine(Neworder.State);
        }
        //Task 10
        List<Order> OrdersList = new List<Order> { };
        while (true)
        {
            Console.WriteLine("Welcome to warehouse management.Choose one of the following:");
            Console.WriteLine("1. Add new order");
            Console.WriteLine("2. Display status of all orders");
            Console.WriteLine("3. Process last order by each robot");
            Console.WriteLine("4. Exit the program");
            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    Console.WriteLine("Type the name of the product that is to be ordered:");
                    var ProductName = Console.ReadLine();
                    Product inputProduct = new Product(ProductName);
                    Order incomingOrder = new Order(inputProduct);
                    OrdersList.Add(incomingOrder);
                    Console.WriteLine("order added");
                    break;
                case "2":
                    foreach (Order item in OrdersList)
                    {
                        Console.WriteLine(item.OrderedProduct.Name + ":" + item.State);
                    }
                    break;
                case "3":
                    Order lastelement = OrdersList[OrdersList.Count - 1];
                    foreach (WarehouseRobot item in creation)
                    {
                        item.ProcessOrder(lastelement);
                    }
                    break;
                case "4":
                    Console.WriteLine("Exit the program");
                    return;
            }
        }
    }

}

