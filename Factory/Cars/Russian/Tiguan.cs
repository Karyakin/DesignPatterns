using Factory.PartsFactory;

namespace Factory.Cars.Russian;

public class Tiguan : Car
{
    private CarPartsFactory _factory;
    public Tiguan(CarPartsFactory factory)
    {
        Name = "Tiguan";
        Boby = "Crossover";
        _factory = factory;
    }

    public override void Configure()
    {
        Console.WriteLine($"Configuring {Name}");
        Console.WriteLine($"Boby is: {Boby}");
        
        _factory.CreateEngine();
        _factory.CreatePaint();
        _factory.CreateWheels();
    }
}