using AbstractFactory.Cars.CarsAbstract;
using AbstractFactory.Cars.Сoncretely.Opel;

namespace AbstractFactory.Cars.Сoncretely;

public class OpelFactory : AbstractCarFactory
{
    public override AbstractBody CreateBody() => new OpelBody();
    public override AbstractWheels CreateWheels() => new OpelWheels();
    public override AbstractEngin CreateEngine() => new OpelEngin();
}