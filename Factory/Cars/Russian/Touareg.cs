using Factory.PartsFactory;

namespace Factory.Cars.Russian;

public class Touareg : Car
{
    private CarPartsFactory _factory;

    public Touareg(CarPartsFactory factory)
    {
        Name = "Touareg";
        Boby = "Jeep";
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