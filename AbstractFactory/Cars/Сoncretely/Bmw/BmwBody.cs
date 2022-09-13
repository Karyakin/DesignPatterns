using AbstractFactory.Cars.CarsAbstract;

namespace AbstractFactory.Cars.Сoncretely.Bmw;

public class BmwBody : AbstractBody
{
    public override void CreateCar(AbstractEngin engin, AbstractWheels wheels)
    {
        Console.WriteLine($"{this} CREATE_BMW - engine:{engin}, wheels:{wheels}");
    }
}