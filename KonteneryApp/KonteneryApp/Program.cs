
namespace KonteneryApp;

public class Program
{
    public static void Main(string[] args)
    { 
        Container k1 = new KontenerNaPlyny(500, 200, 100, 600, 700, "hazard");
        Container k2 = new KontenerNaGaz(200, 300, 300, 500, 300, 1000);
        Container k3 = new KontenerChlodniczy(50, 200, 100, 500, 1000, new Product("Chocolate", -100), 0);

        // Console.WriteLine(k1.SerialNumber);
        // Console.WriteLine(k2.SerialNumber);
        // Console.WriteLine(k3.SerialNumber);
        
        k1.LoadContainer(50); 
        //k1.LoadContainer(1000);

        Kontenerowiec kontenerowiec = new Kontenerowiec(15, 15, 5000);
        
        kontenerowiec.AddContainer(k1);
        kontenerowiec.AddContainer(k2);
        kontenerowiec.AddContainer(k3);
        
        kontenerowiec.Containers.Remove(k2);
        
        // kontenerowiec.Containers.Clear();
        
        kontenerowiec.Log();
        
        kontenerowiec.ReplaceContainer(0, new Container(0,0,0,0,"G",0));
        
        kontenerowiec.MoveContainer(k3, new Kontenerowiec(30, 40, 7000));
    }
}