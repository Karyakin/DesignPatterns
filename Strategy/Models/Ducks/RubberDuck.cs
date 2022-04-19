using Strategy.Fly;
using Strategy.Song;

namespace Strategy.Models.Ducks;

public class RubberDuck : DuckBase
{
    public RubberDuck()
    {
        Flyable = new NoFly();
        //SongAnable = new NoSong();
       SongAnable = new RubberSong();
    }
    public override void Display()
    {
        Console.WriteLine("RubberDuck: Hello, I'm RubberDuck duck!");
    }
}