using Decorator.Models;

namespace Decorator.Decorator;

public class SugarCondiment : CondimentsDecoratorBase
{
    private BeverageBase _beverageBase;

    public SugarCondiment(BeverageBase beverageBase)
    {
        _beverageBase = beverageBase;
        Description = _beverageBase.GetDescription() + " + Sugar";
    }

    public override double GetCost()
    {
        return _beverageBase.GetCost() + 20;
    }
}