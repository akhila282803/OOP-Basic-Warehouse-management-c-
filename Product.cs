//Task 2
class Product
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
            if (string.IsNullOrWhiteSpace(value))
            {
                name = "Product Name";
            }
            else
            {
                name = value;
            }
        }
    }
    public Product(string name)
    {
        Name = name;
    }
}