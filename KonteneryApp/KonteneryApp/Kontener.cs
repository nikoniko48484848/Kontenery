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

    public Container(double loadWeight, double height, double weight, double depth, string type, int num, double maxLoad)
    {
        if (NumsSet.Contains(num))
        {
            throw new Exception("Container with the provided number already exists.");
        }
        LoadWeight = loadWeight;
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = GenerateSerialNumber(type, num);
        NumsSet.Add(num);
        MaxLoad = maxLoad;
    }

    public string GenerateSerialNumber(string type, int num)
    {
        StringBuilder res = new StringBuilder();
        
        res.Append("KON-");
        res.Append(type + "-");
        res.Append(num);
        
        return res.ToString();
    }
    
}