using Strategy.Fly;
using Strategy.Quack;
using Strategy.Song;

namespace Strategy.Models.Ducks;

public abstract class DuckBase
{
    protected IFlyable Flyable;
    protected IQuackable Quackable;
    protected ISongAnable SongAnable;
 
    protected DuckBase()
    {
        Flyable = new FlyWithWings();
        Quackable = new Quack.SimpleQuack();
        SongAnable = new SongAnable();
    }

    public void Song()
    {
        SongAnable.Song();
    }
    
    public void Quack()
    {
       Quackable.Quack();
    }
    public void Fly()
    {
      Flyable.Fly();
    }
    public void Swim()
    {
        Console.WriteLine("DuckBase: I'm swimming!");
    }
    public abstract void Display();
}