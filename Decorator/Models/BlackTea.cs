namespace Decorator.Models;

public class BlackTea : BeverageBase
{

    public BlackTea()
    {
        Description = "Black tea from teabag";
    }


    public override double GetCost()
    {
        return 10;
    }
}