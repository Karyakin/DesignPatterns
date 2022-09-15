using AbstractFactory.Country.Abstract;
using AbstractFactory.Country.Abstract.CountryAttribute;

namespace AbstractFactory.Country;

public class CountryCreator
{
    private AbstractInteractor _interactor;
    private AbstractName _name; 
    private AbstractPopulation _population;

    public CountryCreator(CountryAbstractFactory abstractFactory)
    {
        // обстрактно описывае, как будет порождаться конретный экземпляр семейства
        _interactor = abstractFactory.CountryInteractor();
        _name = abstractFactory.CreateName();
        _population = abstractFactory.CreatePopulation();
    }

    public void Run()
    {
        _interactor.Interact(_name, _population);
    }
}