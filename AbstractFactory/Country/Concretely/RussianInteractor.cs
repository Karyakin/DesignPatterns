using AbstractFactory.Country.Abstract.CountryAttribute;

namespace AbstractFactory.Country.Concretely;

public class RussianInteractor : AbstractInteractor
{
    public override void Interact(AbstractName name, AbstractPopulation population)
    {
        Console.WriteLine($"{this}: Название страны {name}, население {population}");
    }
}