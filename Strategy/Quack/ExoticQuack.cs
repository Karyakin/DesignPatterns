namespace Strategy.Quack;

public class ExoticQuack : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("I'm exotic quack!");
    }
}