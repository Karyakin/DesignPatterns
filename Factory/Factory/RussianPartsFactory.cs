using Factory.Parts;
using Factory.PartsFactory;

namespace Factory.Factory;

public class RussianPartsFactory : CarPartsFactory
{
    public override Engine CreateEngine()
    {
        return new GasolineEngine();
    }

    public override Wheels CreateWheels()
    {
        return new MediumWheels();
    }

    public override Paint CreatePaint()
    {
        return new BlackPaint();
    }
}