using AbstractFactory.Abstract;

namespace AbstractFactory.Сoncretely.Pepsi;

public class PepsiFactory : Abstract.AbstractFactory
{
    public override AbstractBottle CreateBottle() => new PepsiBottle();
    public override AbstractWater CreateWater() => new PepsiWater();
    public override AbstractLabel CreateLabel() => new PepsiLabel();
    public override AbstractCap CreateCap() => new PepsiCap();
}