namespace KonteneryApp;

public class KontenerChlodniczy : Container
{
    public double Temperature { get; set; }
    public Product Product { get; set; }
    public KontenerChlodniczy(double loadWeight, double height, double weight, double depth, double maxLoad, Product product, double temperature) : base(loadWeight, height, weight, depth, "C", maxLoad)
    {
        Product = product;
        Temperature = temperature;
        if (temperature < product.MinTemp)
        {
            throw new Exception("Temperature in container to low for this product!");
        }
    }
}