using Factory.Cars;
using Factory.Cars.Deutsch;

namespace Factory.Facility;

public class DeutschVolkswagenFactory : VolkswagenFactory
{
    protected override Car CreateCar(string type)
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
}