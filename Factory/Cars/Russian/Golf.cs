using Factory.PartsFactory;

namespace Factory.Cars.Russian;

public class Golf : Car
{
    private CarPartsFactory _factory;
    public Golf(CarPartsFactory factory)
    {
        Name = "Golf";
        Boby = "Hatchback";
        _factory = factory;
    }

    public override void Configure()
    {
        Console.WriteLine($"Configuring {Name}");
        Console.WriteLine($"Boby is: {Boby}");
        
        PaintColor = _factory.CreatePaint();
        Engine = _factory.CreateEngine();
        Wheels = _factory.CreateWheels();
        
    }
}