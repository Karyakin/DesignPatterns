namespace AbstractFactory.Cars.CarsAbstract;

public abstract class AbstractCarFactory
{
    public abstract AbstractBody CreateBody();
    public abstract AbstractWheels CreateWheels();
    public abstract AbstractEngin CreateEngine();
}