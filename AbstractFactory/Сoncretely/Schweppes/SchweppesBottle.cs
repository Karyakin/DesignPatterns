using AbstractFactory.Abstract;

namespace AbstractFactory.Сoncretely.Schweppes;

public class SchweppesBottle : AbstractBottle
{
    public override void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label)
    {
        Console.WriteLine($"{this} interacted: {water} + {cap} + {label}");
    }
}