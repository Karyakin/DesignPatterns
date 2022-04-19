using Observer.News;

namespace Observer.Widgets;

public class TwitterWidget :  IWidget
{
    private string _twitter;

    public void Update(object sender, NewsEventArgs args)
    {
        _twitter = args.Twitter;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Twitter: {_twitter}");
    }
}