using Factory.Parts;
using Factory.PartsFactory;

namespace Factory.Factory;

public class DeutschPartsFactory : CarPartsFactory
{
    public override Engine CreateEngine()
    {
        return new DieselEngine();
    }

    public override Wheels CreateWheels()
    {
        return new BigWheels();
    }

    public override Paint CreatePaint()
    {
        return new WhitePaint();
    }
}