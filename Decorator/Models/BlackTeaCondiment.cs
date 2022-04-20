using Decorator.Decorator;

namespace Decorator.Models;

public class BlackTeaCondiment : CondimentsDecoratorBase
{
    private BeverageBase _beverageBase;
    
    public BlackTeaCondiment(BeverageBase beverageBase)
    {
        _beverageBase = beverageBase;
        Description = _beverageBase.GetDescription()+ " + bag of tea";
    }


    public override double GetCost()
    {
        return _beverageBase.GetCost() + 30;
    }
}