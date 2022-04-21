using Factory.Parts;

namespace Factory.PartsFactory;

public abstract class CarPartsFactory
{
    public abstract Engine CreateEngine();
    public abstract Wheels CreateWheels();
    public abstract Paint CreatePaint();
}