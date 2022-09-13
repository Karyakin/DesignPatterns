using AbstractFactory.Country.Abstract;
using AbstractFactory.Country.Abstract.CountryAttribute;

namespace AbstractFactory.Country.Concretely;

public class RussiaFactory : CountryAbstractFactory
{
    public override AbstractPopulation CreatePopulation() => new RussiaPopulation();
    public override AbstractInteractor CountryInteractor() => new RussianInteractor();
    public override AbstractName CreateName() => new RussiaName();
}