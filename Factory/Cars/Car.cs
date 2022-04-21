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