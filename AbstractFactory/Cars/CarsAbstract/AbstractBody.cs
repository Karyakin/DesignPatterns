namespace AbstractFactory.Cars.CarsAbstract;

public abstract class AbstractBody
{
    public abstract void CreateCar(AbstractEngin engin, AbstractWheels wheels);
}