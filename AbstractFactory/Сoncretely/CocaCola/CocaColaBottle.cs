using AbstractFactory.Abstract;

namespace AbstractFactory.Сoncretely.CocaCola;

public class CocaColaBottle : AbstractBottle
{
    public override void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label)
    {
        Console.WriteLine($"{this} interacts: {water}+{cap}+{label}");
    }
}