using System.Text;

namespace KonteneryApp;

public class Container
{
    public double LoadWeight { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public static HashSet<int> NumsSet { get; set; } = new HashSet<int>();
    public double MaxLoad { get; set; }

    public Container(double loadWeight, double height, double weight, double depth, string type, double maxLoad)
    {
        LoadWeight = 0;
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = GenerateSerialNumber(type);
        NumsSet.Add(GenerateNumber());
        MaxLoad = maxLoad;
    }

    public string GenerateSerialNumber(string type)
    {
        StringBuilder res = new StringBuilder();
        
        res.Append("KON-");
        res.Append(type + "-");
        res.Append(GenerateNumber());
        
        return res.ToString();
    }

    public int GenerateNumber()
    {
        int num = 0;
        while (NumsSet.Contains(num))
        {
            num++;
        }
        return num;
    }

    public void EmptyContainer()
    {
        LoadWeight = 0;
    }

    public void PutIntoContainer(double weight)
    {
        double spaceLeft = MaxLoad - LoadWeight;
        if (spaceLeft < weight)
            throw new OverfillException("There's not enough space left in the container.");
    }
}
public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) {}
}