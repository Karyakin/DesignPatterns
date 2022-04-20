namespace Decorator.Models;

public class Capuccino : BeverageBase
{
    public Capuccino()
    {
        Description = "Coffee with milk";
    }


    public override double GetCost()
    {
        return 30;
    }
}