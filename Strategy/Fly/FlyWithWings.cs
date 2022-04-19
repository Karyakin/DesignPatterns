namespace Strategy.Fly;

public class FlyWithWings : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with wings!");
    }
}