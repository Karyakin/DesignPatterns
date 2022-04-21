using Factory.Cars;

namespace Factory.Facility;

public abstract class VolkswagenFactory
{
    public Car GetCar(string type)
    {
        Car car = CreateCar(type);
        car.Configure();
        car.AssembleBody();
        car.InstallEngine();
        car.InstallWheels();
        car.Paint();

        return car;
    }

    protected abstract Car CreateCar(string type);
}