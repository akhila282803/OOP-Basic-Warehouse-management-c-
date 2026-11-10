//Task 6
class PackingRobot : WarehouseRobot
{
    public PackingRobot(string name) : base(name)
    {

    }
    public override void ProcessOrder(Order O)
    {
        O.State = "Packed";
    }
}