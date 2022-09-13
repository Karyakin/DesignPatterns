using AbstractFactory.Cars.CarsAbstract;
using AbstractFactory.Cars.Сoncretely.Bmw;

namespace AbstractFactory.Cars.Сoncretely;

public class BmwFactory : AbstractCarFactory
{
    public override AbstractBody CreateBody() => new BmwBody();
    public override AbstractWheels CreateWheels() => new BmwWheels();
    public override AbstractEngin CreateEngine() => new BmwEngin();
}