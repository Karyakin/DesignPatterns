using AbstractFactory.Country.Abstract;
using AbstractFactory.Country.Abstract.CountryAttribute;

namespace AbstractFactory.Country.Concretely.Africa;

public class AfricaFactory : CountryAbstractFactory
{
    public override AbstractPopulation CreatePopulation()
        => new AfricaPopulation();

    public override AbstractInteractor CountryInteractor()
        => new AfricaInteractor();

    public override AbstractName CreateName()
        => new AfricaName();
}