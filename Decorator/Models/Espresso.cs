namespace Decorator.Models;

public class Espresso : BeverageBase
{
    public Espresso()
    {
        Description = "Small portion of strong coffe";
    }


    public override double GetCost()
    {
        return 20;
    }
}