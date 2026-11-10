//Task 8 
class DeliveryRobot : WarehouseRobot
{
    public DeliveryRobot(string name) : base(name)
    {

    }
    public override void ProcessOrder(Order O)
    {
        O.State = "Delivered";
    }
}