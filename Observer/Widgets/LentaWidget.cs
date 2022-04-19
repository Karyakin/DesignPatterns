using Observer.News;

namespace Observer.Widgets;

public class LentaWidget : IWidget
{
    private string _lenta;

    public void Update(object sender, NewsEventArgs args)
    {
        _lenta = args.Lenta;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Lenta: {_lenta}");
    }
}