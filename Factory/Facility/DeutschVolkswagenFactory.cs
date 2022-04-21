using Factory.Cars;
using Factory.Cars.Russian;
using Factory.Factory;
using Factory.PartsFactory;

namespace Factory.Facility;

public class DeutschVolkswagenFactory : VolkswagenFactory
{
    protected override Car CreateCar(string type)
    {
        Car car;

        CarPartsFactory factory = new DeutschPartsFactory();

        if (type == "Golf")
            return new Golf(factory);
        if (type == "Touareg")
            return new Touareg(factory);
        if (type == "Tiguan")
            return new Tiguan(factory);
        if (type == "Passat")
            return new Passat(factory);

        return null;
    }
}