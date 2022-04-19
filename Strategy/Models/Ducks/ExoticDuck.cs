using Strategy.Quack;

namespace Strategy.Models.Ducks;

public class ExoticDuck : DuckBase
{
    public ExoticDuck()
    {
        Quackable = new ExoticQuack();
    }
    public override void Display()
    {
        Console.WriteLine("ExoticDuck: Hello, I'm exotic duck!");
    }
}