namespace KonteneryApp;

public class Kontenerowiec
{
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }

    public Kontenerowiec(double maxSpeed, int maxContainers, double maxWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void AddContainer(Container container)
    {
        double totalWeight = 0;
        foreach (var c in Containers)
        {
            totalWeight += c.Weight + c.LoadWeight;
        }

        double allowedWeight = MaxWeight - totalWeight;
        if (Containers.Count != MaxContainers && (container.Weight + container.LoadWeight) < allowedWeight)
        {
            Containers.Add(container);
        } 
    }

    public void ReplaceContainer(int number, Container container)
    {
        Container foundContainer = Containers.Find(c => int.Parse(c.SerialNumber.Split("-")[2]) == number);
    
        if (foundContainer != null)
        {
            int index = Containers.IndexOf(foundContainer);
            Containers[index] = container;
        }
        else
        {
            throw new Exception("Container with the specified number not found!");
        }
    }

    public void MoveContainer(Container container, Kontenerowiec k2)
    {
        if (Containers.Contains(container))
        {
            Containers.Remove(container);
            k2.Containers.Add(container);
        }
        else
        {
            throw new Exception("This container is not on this ship!");
        }
    }

    public void Log()
    {
        foreach (var c in Containers)
        {
            Console.WriteLine("1." + c.SerialNumber);
        }

        Console.WriteLine("Max Speed: " + MaxSpeed + "\nMax Containers: " + MaxContainers + "\nMax Weight : " + MaxWeight);
    }
}