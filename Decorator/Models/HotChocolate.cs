namespace Decorator.Models;

public class HotChocolate : BeverageBase
{
    public HotChocolate()
    {
        Description = "Hot chocolate";
    }


    public override double GetCost()
    {
        return 50;
    }
}