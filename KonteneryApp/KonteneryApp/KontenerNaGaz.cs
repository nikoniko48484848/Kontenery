namespace KonteneryApp;

public class KontenerNaGaz : Container, IHazardNotifier
{
    public Double Pressure { get; set; }
    public KontenerNaGaz(double loadWeight, double height, double weight, double depth, double maxLoad, double pressure) : base(loadWeight, height, weight, depth, "G", maxLoad)
    {
        Pressure = pressure;
    }

    public override void EmptyContainer()
    {
        LoadWeight = LoadWeight * 0.05;
    }

    public void NotifyHazard()
    {
        Console.WriteLine("Hazard in gas container number: " + SerialNumber);
    }
}