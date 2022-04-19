using Observer.News;

namespace Observer.Widgets;

public class LentaWidget : IWidgetObserver, IWidget
{
    private string _lenta;
    private ISubject _subject;

    public LentaWidget(ISubject subject)
    {
        _subject = subject;
        subject.RegisterObserver(this);
    }
    public void Update(string twitter, string lenta, string tv)
    {
        _lenta = lenta;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Lenta: {_lenta}");
    }

    public void RemoveFromSubject()
    {
        _subject.RemoveObserver(this);
    }
}