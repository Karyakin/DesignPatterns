using Factory.PartsFactory;

namespace Factory.Cars.Russian;

public class Passat : Car
{
    private Passat _factory;
    public Passat(CarPartsFactory factory)
    {
        _factory = factory;
    }

    public override void Configure()
    {
        Console.WriteLine($"Configuring {Name}");
        Console.WriteLine($"Boby is: {Boby}");
        
        PaintColor = _factory.CreatePaint();
        Engine = _factory.CreateEngine();
        Wheels = _factory.CreateWheels();
        
        
       
        Console.WriteLine($"Paint color is: {PaintColor}");
        Console.WriteLine($"Wheels are {Wheels}");
    }
}