using Strategy.Song;
using Strategy.Swimming;

namespace Strategy.Models.Ducks;

public class SimpleDuck: DuckBase
{
    public SimpleDuck()
    {
        Quackable = new SimpleQuack();
        SongAnable = new NoSong();
    }
    public override void Display()
    {
        Console.WriteLine("SimpleDuck: Hello, I'm simple duck!");
    }
}