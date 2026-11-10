//Task 8
class DispatchRobot : WarehouseRobot
{
    public DispatchRobot(string name) : base(name)
    {

    }
    public override void ProcessOrder(Order O)
    {
        O.State = "Dispatched";
    }
}