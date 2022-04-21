/*using Factory.Cars;
using Factory.Cars.Deutsch;

namespace Factory.Factory;

public class SimpleFactory
{
    public Car GetCar(string type)
    {
        var car = new Car();
        
        if (type == "Golf")
            car = new DeutschGolf();
        if (type == "Touareg")
            car = new DeutschTouareg();
        if (type == "Tiguan")
            car = new DeutschTiguan();
        if (type == "Passat")
            car = new DeutschPassat();

        return car;
    }
}*/