namespace Decorator.Models;

public abstract class BeverageBase
{
    protected string Description = "";

    public string GetDescription()
    {
        return Description;
    }

    public abstract double GetCost();
}