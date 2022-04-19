using Strategy.Quack;

namespace Strategy.Swimming;

public class SimpleQuack : IQuackable
{
    public void Quack()
    {
       Console.WriteLine("I simple Quack!");
    }
}