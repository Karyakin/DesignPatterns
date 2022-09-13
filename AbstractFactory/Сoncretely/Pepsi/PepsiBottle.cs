using AbstractFactory.Abstract;

namespace AbstractFactory.Сoncretely.Pepsi;

public class PepsiBottle : AbstractBottle
{
    public override void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label)
    {
        Console.WriteLine($"{this} interacts: {water}+{cap}+{label}");
    }
}