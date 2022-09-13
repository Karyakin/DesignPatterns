using AbstractFactory.Abstract;
using AbstractFactory.Сoncretely.Pepsi;

namespace AbstractFactory.Сoncretely.Schweppes;

public class SchweppesFactory : Abstract.AbstractFactory
{
    public override AbstractBottle CreateBottle() => new SchweppesBottle();
    public override AbstractLabel CreateLabel() => new SchweppesLabel();
    public override AbstractCap CreateCap() => new SchweppesCap();
    public override AbstractWater CreateWater() => new SchweppesWater();
}