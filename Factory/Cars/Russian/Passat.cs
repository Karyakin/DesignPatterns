﻿using Factory.PartsFactory;

namespace Factory.Cars.Russian;

public class Passat : Car
{
    private CarPartsFactory _factory;
    public Passat(CarPartsFactory factory)
    {
        Name = "Passat";
        Boby = "Sedan";
        _factory = factory;
    }

    public override void Configure()
    {
        Console.WriteLine($"Configuring {Name}");
        Console.WriteLine($"Boby is: {Boby}");
        
        PaintColor = _factory.CreatePaint();
        Engine = _factory.CreateEngine();
        Wheels = _factory.CreateWheels();
  
        Console.WriteLine($"Wheels are {Wheels}");
    }
}