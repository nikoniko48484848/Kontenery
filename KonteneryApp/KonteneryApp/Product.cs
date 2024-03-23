namespace KonteneryApp;

public class Product
{
    public string Type;
    public double MinTemp;

    public Product(string type, double minTemp)
    {
        Type = type;
        MinTemp = minTemp;
    }
}