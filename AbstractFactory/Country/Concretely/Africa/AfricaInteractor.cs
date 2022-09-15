using AbstractFactory.Country.Abstract.CountryAttribute;

namespace AbstractFactory.Country.Concretely.Africa;

public class AfricaInteractor : AbstractInteractor
{
    public override void Interact(AbstractName name, AbstractPopulation population)
    {
        Console.WriteLine($"{this}: Название страны {name}, население {population}");
    }
}