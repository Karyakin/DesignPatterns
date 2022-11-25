using Decorator.Models;

namespace Decorator.Decorator;

public class ChocolateCondiment : CondimentsDecoratorBase
{
    private BeverageBase _beverageBase;

    public ChocolateCondiment(BeverageBase beverageBase)
    {
        _beverageBase = beverageBase;
        Description = _beverageBase.GetDescription() + " + Chocolate";
    }

    public override double GetCost()
    {
        return _beverageBase.GetCost() + 20;
    }
}