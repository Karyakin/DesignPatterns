using Factory.Cars;
using Factory.Cars.Deutsch;
using Factory.Cars.Russian;
using Factory.Factory;
using Factory.PartsFactory;

namespace Factory.Facility;

public class RussianVolkswagenFactory : VolkswagenFactory
{
    protected override Car CreateCar(string type)
    {
        Car car;

        CarPartsFactory factory = new RussianPartsFactory();

        if (type == "Golf")
            return new Golf(factory);
        if (type == "Touareg")
            return new RussianTouareg(factory);
        if (type == "Tiguan")
            return new RussianTiguan(factory);
        if (type == "Passat")
            return new Passat(factory);

        return null;
    }
}