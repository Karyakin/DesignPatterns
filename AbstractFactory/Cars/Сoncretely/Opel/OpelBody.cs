using AbstractFactory.Cars.CarsAbstract;

namespace AbstractFactory.Cars.Сoncretely.Opel;

public class OpelBody : AbstractBody
{
    public override void CreateCar(AbstractEngin engin, AbstractWheels wheels)
    {
       Console.WriteLine($"{this} createOpel: engin:{engin}, wheels:{wheels}");
    }
}