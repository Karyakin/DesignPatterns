using AbstractFactory.Country.Abstract.CountryAttribute;

namespace AbstractFactory.Country.Abstract;

public abstract class CountryAbstractFactory
{
    public abstract AbstractPopulation CreatePopulation();
    public abstract AbstractInteractor CountryInteractor();
    public abstract AbstractName CreateName();
}