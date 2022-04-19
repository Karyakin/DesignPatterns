using Observer.News;

namespace Observer.Widgets;

public class TvWidget: IWidgetObserver, IWidget
{
    private string _tv;
    private ISubject _subject;
    public TvWidget(ISubject subject)
    {
        _subject = subject;
        subject.RegisterObserver(this);
    }
    public void Update(string twitter, string lenta, string tv)
    {
        _tv = tv;
        Display();

    }

    public void Display()
    {
        Console.WriteLine($"Tv: {_tv}");
    }

    public void RemoveFromSubject()
    {
        _subject.RemoveObserver(this);
    }
}