using Decorator.Models;

namespace Decorator.Decorator;

public class MilkCondiment : CondimentsDecoratorBase
{
    private BeverageBase _beverageBase;

    public MilkCondiment(BeverageBase beverageBase)
    {
        _beverageBase = beverageBase;
        Description = _beverageBase.GetDescription() + " + milk";
    }
    
    public override double GetCost()
    {
        return _beverageBase.GetCost() + 50;
    }
}