

//Task 5
abstract class WarehouseRobot
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public WarehouseRobot(string name)
    {
        Name = name;
    }
    public abstract void ProcessOrder(Order o);
}