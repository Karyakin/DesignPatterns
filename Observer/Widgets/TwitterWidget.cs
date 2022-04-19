using Observer.News;

namespace Observer.Widgets;

public class TwitterWidget : IWidgetObserver, IWidget
{
    private string _twitter;
    private ISubject _subject;

    public TwitterWidget(ISubject subject)
    {
        _subject = subject;
        subject.RegisterObserver(this);
    }

    public void Update(string twitter, string lenta, string tv)
    {
        _twitter = twitter;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Twitter: {_twitter}");
    }

    public void RemoveFromSubject()
    {
        _subject.RemoveObserver(this);
    }
}