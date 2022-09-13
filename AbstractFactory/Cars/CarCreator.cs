using AbstractFactory.Cars.CarsAbstract;
using AbstractFactory.Cars.Сoncretely.Opel;

namespace AbstractFactory.Cars;

public class CarCreator
{
    private AbstractBody _body;
    private AbstractEngin _engin;
    private AbstractWheels _wheels;

    public CarCreator(AbstractCarFactory carFactory)
    {
        _body = carFactory.CreateBody();
        _engin = carFactory.CreateEngine();
        _wheels = carFactory.CreateWheels();
    }

    public void Run()
    {
        _body.CreateCar(_engin, _wheels);
    }
}