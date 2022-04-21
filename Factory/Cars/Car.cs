using Factory.Parts;

namespace Factory.Cars;

public abstract class Car
{
    protected string Name = "";
    protected string Boby = "Caravan";

    protected Engine Engine;
    protected Paint PaintColor;
    protected Wheels Wheels;

    public abstract void Configure();
    /*{
        Console.WriteLine($"Configuring {Name}");
        Console.WriteLine($"Engine is: {Engine}");
        Console.WriteLine($"Boby is: {Boby}");
        Console.WriteLine($"Paint color is: {PaintColor}");
        Console.WriteLine($"Wheels are {Wheels}");
    }*/

    public void AssembleBody()
    {
        Console.WriteLine("Body is assembled");
    }

    public void InstallEngine()
    {
        Console.WriteLine("Engin is in its place");
    }
    
    public void Paint()
    {
        Console.WriteLine("Car is painted");
    }
    
    public void InstallWheels()
    {
        Console.WriteLine("Wheels are installed");
    }
}