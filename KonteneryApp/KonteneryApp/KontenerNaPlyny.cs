namespace KonteneryApp;

public class KontenerNaPlyny : Container, IHazardNotifier
{
    public string LoadType { get; set; }
    
    
    public KontenerNaPlyny(double loadWeight, double height, double weight, double depth, double maxLoad, string loadType) : base(
        loadWeight, height, weight, depth, "L", maxLoad)
    {
        LoadType = loadType;
    }


    public void NotifyHazard()
    {
       Console.WriteLine("Hazardous liquid in container number: " + SerialNumber); 
    }
    
    public override void LoadContainer(double weight)
    {
        double hazardSpaceLeft = MaxLoad*0.5 - LoadWeight;
        double normalSpaceLeft = MaxLoad*0.9 - LoadWeight;
        if (LoadType == "hazard")
        {
            if (hazardSpaceLeft < weight)
            {
                Console.WriteLine("Hazardous liquid could be overfilled!");
                throw new OverfillException("There's not enough space left in the container.");
            }
        }
        else
        {
            if (normalSpaceLeft < weight)
            {
                Console.WriteLine("Normal liquid could be overfilled!");
                throw new OverfillException("There's not enough space left in the container.");
            }
        }
    }
}