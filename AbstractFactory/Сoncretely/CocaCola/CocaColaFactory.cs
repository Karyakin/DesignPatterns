using AbstractFactory.Abstract;

namespace AbstractFactory.Сoncretely.CocaCola;

public class CocaColaFactory : Abstract.AbstractFactory
{
    public override AbstractBottle CreateBottle() => new CocaColaBottle();
    public override AbstractWater CreateWater() => new CocaColaWater();
    public override AbstractLabel CreateLabel() => new CocaColaLabel();
    public override AbstractCap CreateCap() => new CocaColaCap();

}