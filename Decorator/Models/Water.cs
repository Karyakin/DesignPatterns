namespace Decorator.Models;

public class Water : BeverageBase
{

    public Water()
    {
        Description = "Hot water";
    }
    public override double GetCost()
    {
        return 3;
    }
}