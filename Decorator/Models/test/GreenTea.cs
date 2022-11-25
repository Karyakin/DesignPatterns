namespace Decorator.Models;

public class GreenTea : BeverageBase
{
    public GreenTea()
    {
        Description = "Green tea";
    }

    public override double GetCost()
    {
        return 100;
    }
}