using Strategy.Fly;
using Strategy.Quack;
using Strategy.Song;

namespace Strategy.Models.Ducks;

public class WoodenDuck : DuckBase
{
    public WoodenDuck()
    {
        Flyable = new NoFly();
        Quackable = new NoQuack();
        SongAnable = new NoSong();
    }
    public override void Display()
    {
        Console.WriteLine("WoodenDuck: Hello, I'm WoodenDuck duck!");
    }
}