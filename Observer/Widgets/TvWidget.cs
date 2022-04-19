using Observer.News;

namespace Observer.Widgets;

public class TvWidget: IWidget
{
    private string _tv;

    public void Update(object sender, NewsEventArgs args)
    {
        _tv = args.Tv;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Tv: {_tv}");
    }
}